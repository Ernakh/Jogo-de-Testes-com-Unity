using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    public bool perseguir = false;
    public bool atacar = false;
    private Renderer ren;
    private NavMeshAgent nav;
    private Rigidbody rbp;
    public GameObject personagem;
    private Player player;
    private int vida = 100;
    public Text txtVida;

    public GameObject _point;
    public GameObject _bullet;

    // Use this for initialization
    void Start()
    {
        ren = this.GetComponent<Renderer>();
        ren.material.color = Color.green;
        nav = this.GetComponent<NavMeshAgent>();
        rbp = personagem.GetComponent<Rigidbody>();
        player = personagem.GetComponent<Player>();
    }

    void FixedUpdate()
    {
        txtVida.text = vida.ToString();

        print(Vector3.Distance(this.transform.position, personagem.transform.position));

        if (perseguir)
        {
            if (Vector3.Distance(this.transform.position, personagem.transform.position) > 6)
            {
                //StartCoroutine(cacar(personagem.transform.position));
                nav.destination = personagem.transform.position;
            }
            else
            {
                nav.isStopped = true;
                //this.transform.LookAt(personagem.transform.position);

                if (atacar)
                {
                    StartCoroutine(TempoDeAtaque());
                }
            }
        }

        if (vida <= 0)
        {
            //fim de jogo, vitoria do player
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projetil"))
        {
            Destroy(other.gameObject);
            vida -= Random.Range(20, 40);
        }
    }

    public void setAtacar(bool atacar)
    {
        this.perseguir = atacar;
        ren.material.color = Color.red;
        //nav.Warp(personagem.transform.position);
        //nav.SetDestination(personagem.transform.position);
    }


    IEnumerator TempoDeAtaque()
    {
        atacar = false;
        Instantiate(_bullet, _point.transform.position, _point.transform.rotation);
        yield return new WaitForSeconds(1);
        atacar = true;
    }

    /* private IEnumerator cacar(Vector3 posicao)
     {
         nav.Warp(posicao * Time.deltaTime);
         yield return null;
     }*/
}
