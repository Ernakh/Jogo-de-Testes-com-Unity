using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    private float _time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate((8 * Time.deltaTime), 0, 0);

        _time += 1 * Time.deltaTime;

        if (_time >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
