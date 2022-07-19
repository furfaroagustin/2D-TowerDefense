using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 4f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") == true)
        {
            Destroy(gameObject);
        }
        
    }
    private void Update()
    {
        transform.position +=transform.right * 0.1f;
    }
}
