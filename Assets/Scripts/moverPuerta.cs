using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPuerta : MonoBehaviour
{
    public float velocidad;
    public bool haciaIzquierda = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vigilarPosicion();

        mover();

    }

    void vigilarPosicion()
    {
        if (transform.position.x < 5)
        {
            haciaIzquierda = false;
        }
        else if (transform.position.x > 7.2f)
        {
            haciaIzquierda = true;
        }
    }

    void mover()
    {
        if (haciaIzquierda == true)
        {
            transform.Translate(velocidad * Vector2.left * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(velocidad * Vector2.right * Time.deltaTime, Space.World);
        }
    }
}
