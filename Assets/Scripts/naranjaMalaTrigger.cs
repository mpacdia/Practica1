using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naranjaMalaTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "personaje")
        {
            moverPersonaje.encoger();
            Destroy(gameObject);
        }
    }
}
