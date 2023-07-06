using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBrain : MonoBehaviour
{
    public float hiz = 2f; 
    private Vector2 hedefNokta;

    private void Start()
    {
        HedefNoktaBelirle();
    }
    private void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, hedefNokta, hiz * Time.deltaTime);

        Vector2 yon = hedefNokta - (Vector2)transform.position;

        transform.up = yon;


        if (Vector2.Distance(transform.position, hedefNokta) < 0.1f)
        {
            HedefNoktaBelirle();
        }
    }
    private void HedefNoktaBelirle()
    {

        hedefNokta = new Vector2(Random.Range(-3f, 3f), Random.Range(-4f, 4f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
        }
    }
}
