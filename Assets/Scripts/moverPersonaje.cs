using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moverPersonaje : MonoBehaviour
{
    public float movX, movY;
    Rigidbody2D rb;

    private int naranjas = 0;

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

    private void contadorNaranjas(int naranjas)
    {
        if (naranjas == 0)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja0;
        }

        if (naranjas == 1)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja1;
        }


        if (naranjas == 2)
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja2
        }

        if (naranjas == 3
        {
            contadorNaranjas.GetComponent<Image>().sprite = naranja3
        }
    }
}