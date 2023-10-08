using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moverPersonaje : MonoBehaviour
{
    public float movX, movY;
    Rigidbody2D rb;

    public int gestorNaranjas = 0;

    [Header("CONTADOR NARANJAS")]
    [SerializeField] private GameObject contadorNaranjas;
    [SerializeField] private Sprite naranja0, naranja1, naranja2, naranja3;

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

    // Función para agarrar una naranja
    public void AgarrarNaranja()
    {
        gestorNaranjas++; // Incrementa el contador de naranjas
        actualizarContadorNaranjas(); // Actualiza la visualización del contador
        Destroy(GameObject.FindGameObjectWithTag("Naranja")); // Destruye el objeto de la naranja agarrada
    }


    // Función para actualizar la visualización del contador de naranjas
    private void actualizarContadorNaranjas()
    {
        if (gestorNaranjas == 0)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja0;
        }
        else if (gestorNaranjas == 1)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja1;
        }
        else if (gestorNaranjas == 2)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja2;
        }
        else if (gestorNaranjas == 3)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja3;
        }
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