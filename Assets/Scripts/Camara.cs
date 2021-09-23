using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = player.position.x + 4;
        var y = player.position.y + 1f;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
