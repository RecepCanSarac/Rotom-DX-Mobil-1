using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenScripts : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Force = 250;
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyScripts>().health = 0;
        }
    }
}
