using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porta : MonoBehaviour
{
    private bool aberta = false;
    public GameObject jogador;
    public GameObject inimigo;
    private Player player;
    private Inimigo inimigoScript;
    public float distanciaMinima = 5;
    private float distancia = 15;
    private Text texto;

    private Animator animacao;
    private AudioSource audio;

    // Use this for initialization
    void Start()
    {
        texto = GameObject.Find("TextMessage").GetComponent<Text>();
    }

    private void Awake()
    {
        player = jogador.GetComponent<Player>();
        inimigoScript = inimigo.GetComponent<Inimigo>();

        animacao = this.GetComponent<Animator>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!aberta)
        {
            distancia = Vector3.Distance(this.transform.position, jogador.transform.position);
            //print(distancia.ToString());

            if (distancia <= distanciaMinima)
            {
                texto.text = "Pressione E para abrir a porta!";

                if (Input.GetKey(KeyCode.E))
                {
                    if (player.keys > 0)
                    {
                        animacao.SetBool("Abrir", true);
                        audio.Play();
                        player.keys--;
                        texto.text = "";
                        aberta = true;
                        inimigoScript.setAtacar(true);
                    }
                    else
                    {
                        texto.text = "Você não possui a chave!";
                    }
                }
            }
            else
            {
                texto.text = "";
            }
        }
    }
}
