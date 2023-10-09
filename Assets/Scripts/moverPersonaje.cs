using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class moverPersonaje : MonoBehaviour
{
    static moverPersonaje current;

    public float movX, movY;
    Rigidbody2D rb;

    public int gestorNaranjas;

    public TMP_Text contadorNaranjas;
   
    public static void sumaNaranja()
    {
        current.gestorNaranjas++;
        if (current.gestorNaranjas < 10) current.contadorNaranjas.text = current.gestorNaranjas.ToString();
    }

    private void Awake()
    {
        current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 vector = new Vector2(movX, movY);

        rb.velocity = vector * 15;
    }


    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("personaje") && gestorNaranjas < 3)
        {
            if (gestorNaranjas == 3)
            {
                Debug.Log("Fin del juego :)");
            }
            else
            {
                Debug.Log("Recoge más Naranjas");
            }
        }
    }
}