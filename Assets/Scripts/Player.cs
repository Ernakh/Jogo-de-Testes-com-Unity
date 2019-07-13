using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int keys = 0;
    private Text keysText;
    public int vida = 100;
    public Text txtVida;

    public GameObject _point;
    public GameObject _bullet;

    // Use this for initialization
    void Start()
    {
        keysText = GameObject.Find("KeyCount").GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        txtVida.text = vida.ToString();
        keysText.text = keys.ToString();
        //print(keys);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_bullet, _point.transform.position, _point.transform.rotation);
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
}
