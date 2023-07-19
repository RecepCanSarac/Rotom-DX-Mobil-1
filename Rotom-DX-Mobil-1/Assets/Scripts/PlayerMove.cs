using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    [SerializeField] private float Force;
    public int health;
    private Rigidbody2D ballRB;    
    private Rigidbody2D playerRB;
    private BoxCollider2D collider;
    private CircleCollider2D colliderBall;
    private GameObject _tranbolin;
    [SerializeField] private TextMeshProUGUI HealthText;
    [SerializeField] private GameObject TryAgainPanel;
    void Start()
    {
        health = 3;
        playerRB = GetComponent<Rigidbody2D>();
        ballRB = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        colliderBall = GameObject.FindGameObjectWithTag("Ball").GetComponent<CircleCollider2D>();
        Time.timeScale = 1.00f;
    }
    private void Update()
    {
        if (health <=0)
        {
            TryAgainPanel.SetActive(true);
            Time.timeScale = 0.00f; 
        }
        else
        {
            TryAgainPanel.SetActive(false);
            Time.timeScale = 1.00f;
        }
    }
    public void leftMove()
    {

        playerRB.velocity = new Vector2(-speed * Time.deltaTime, playerRB.velocity.y);

        float xPos = Mathf.Clamp(transform.position.x, -3f, 3f);
        transform.position = new Vector2(xPos, transform.position.y);
    }
    public void rightMove()
    {
        playerRB.velocity = new Vector2(speed * Time.deltaTime, playerRB.velocity.y);

        float xPos = Mathf.Clamp(transform.position.x, -3f, 3f);
        transform.position = new Vector2(xPos, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            health--;
            HealthText.text ="Healt:"+health.ToString();
            ballRB.velocity = new Vector2(ballRB.velocity.x, Force);
        }

      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Upgrade"))
        {
            IController PlayerUpgrade = collision.gameObject.GetComponent<IController>();
            if (PlayerUpgrade != null)
            {
                speed = 325;
                collider.isTrigger = false;
                colliderBall.isTrigger = false;
                Time.timeScale = 1.0f;
                _tranbolin = GameObject.FindGameObjectWithTag("Tranbolin");
                if (_tranbolin != null)
                {
                    Destroy(_tranbolin);
                }
                PlayerUpgrade.PlayerUpgrade();
            }
        }
    }

    public void LevelScene()
    {
        SceneManager.LoadScene(1);
    }
    public void TryScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
