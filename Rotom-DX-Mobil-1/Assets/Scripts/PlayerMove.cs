using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Force;
    [SerializeField] private int health;
    private Rigidbody2D playerRB;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }
    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        playerRB.velocity = new Vector2 (horizontalMove * speed * Time.deltaTime, playerRB.velocity.y);

        float xPos = Mathf.Clamp(transform.position.x, -3f, 3f);
        transform.position = new Vector2(xPos,transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,Force);
        }
    }
}
