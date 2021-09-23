using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Megaman : MonoBehaviour
{
    public float Velocidad = 5;
    public float fuerza_salto = 30;

    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;

    public Transform posicion_bala;
    public GameObject Disparo1;
    public GameObject Disparo2;
    public GameObject Disparo3;
    //public GameObject Disparo_;

    private float disparo2Tiempo=3.0f;
    private float disparo3Tiempo=5.0f;

    private float tiempo1_ = 0.0f;
    private float tiempo2_ = 0.0f;
    private float tiempo3_ = 0.0f;
    private bool activa = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        animator.SetInteger("Estado", 0);
        rb.velocity = new Vector2(0, rb.velocity.y);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Estado", 1);
            rb.velocity = new Vector2(Velocidad, rb.velocity.y);
            sr.flipX = false;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Estado", 1);
            sr.flipX = true;
            rb.velocity = new Vector2(Velocidad * -1, rb.velocity.y);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerza_salto,ForceMode2D.Impulse);
            animator.SetInteger("Estado", 4);
        }

            tiempo1_= Time.time;
        
        if (Input.GetKeyUp(KeyCode.X) && tiempo1_<disparo2Tiempo && tiempo1_<disparo3Tiempo)
        {
            Instantiate(Disparo1, posicion_bala.position, posicion_bala.rotation);
               animator.SetInteger("Estado", 3);
            activa = true;
        }


        if (Input.GetKeyUp(KeyCode.X) && tiempo1_ > disparo2Tiempo && tiempo1_ < disparo3Tiempo)
        {

            Instantiate(Disparo2, posicion_bala.position, posicion_bala.rotation);
            Debug.Log("tiempo: " + tiempo1_);
            
        }
        
        if (Input.GetKeyUp(KeyCode.X) && tiempo1_ > disparo3Tiempo && tiempo1_ > disparo2Tiempo)
            {

            Instantiate(Disparo3, posicion_bala.position, posicion_bala.rotation);
            Debug.Log("tiempo: " + tiempo1_);
            
        }


    }

    
}
