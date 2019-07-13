using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coletavel : MonoBehaviour
{
    //public static Player Instance;
    public GameObject jogador;
    private Player player;
    public float distanciaMinima = 3f;
    private float distancia = 10;

    private Text texto;

    // Use this for initialization
    void Start()
    {
texto = GameObject.Find("TextMessage").GetComponent<Text>();
    }

    //igual o start, mas depois que todo o jogo foi carregado
    private void Awake()
    {
        player = jogador.GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, -40 * Time.deltaTime);

        distancia = Vector3.Distance(this.transform.position, jogador.transform.position);

        //print(distancia.ToString());

        if (distancia <= distanciaMinima)
        {
            //print(texto.text);
            texto.text = "Pressione E para pegar a chave!";
            //print(texto.text);

            if (Input.GetKey(KeyCode.E))
            {
                player.keys++;
                texto.text = "";
                Destroy(this.gameObject);
            }
        }
        else
        {
            texto.text = "";
        }
    }
}
