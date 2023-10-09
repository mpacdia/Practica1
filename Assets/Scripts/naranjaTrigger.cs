using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naranjaTrigger : MonoBehaviour
{ 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "personaje")
        {
            moverPersonaje.sumaNaranja();
            Destroy(gameObject);
        }
    }

}
