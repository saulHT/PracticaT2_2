using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private int contadorA = 0;
    private int contadorB = 0;
    private int contadorC = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="A")
        {
            contadorA++;
            Debug.Log("A: "+contadorA);

            if (contadorA ==5)
            {
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "B")
        {
            contadorB++;
            Debug.Log("B: "+contadorB);
            if (contadorB == 2)
            {
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "C")
        {
            contadorC++;
            Debug.Log("C= "+contadorC);

            if (contadorC == 1)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
