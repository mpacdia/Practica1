using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class moverPersonaje : MonoBehaviour
{
    static moverPersonaje current;

    public static bool tieneLlave = false;

    public float movX, movY;
    Rigidbody2D rb;

    public int gestorNaranjas = 0;

    public TMP_Text contadorNaranjas;

    public static float size = 0.25f;

    public static void encoger()
    {
        current.GetComponent<Transform>().localScale *= 0.75f;
    }

    public static void llave()
    {
        tieneLlave = true;
    }

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
        transform.localScale = new Vector2(size, size);
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

        rb.velocity = vector * 5;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "luna")
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

        if (collision.gameObject.tag == "obstaculo")
        {
            rb.velocity = Vector2.zero * Time.deltaTime * 2;
        }
    }
}