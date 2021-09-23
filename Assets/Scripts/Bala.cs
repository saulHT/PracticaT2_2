using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity_ = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3);
    }

    
    void Update()
    {
        rb.velocity = new Vector2(velocity_, rb.velocity.y);
    }
}
