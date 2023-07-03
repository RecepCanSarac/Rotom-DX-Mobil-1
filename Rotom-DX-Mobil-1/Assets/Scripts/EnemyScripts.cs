using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [SerializeField] EnemyData _enemyData;
    private int health;
    private bool Special;
    public bool die;
    public int spacialNum;

    private UpgradeData _upgradeData;
    private void Awake()
    {
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
    }
    void Start()
    {
        health = _enemyData.Health;
        Special = _enemyData.special;
        die = false;
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            health--;
            if (health <= 0)
            {
                if (Special)
                {
                    spacialNum = Random.Range(0, _upgradeData._upgradeScripts.Length);
                    die = true;
                }

                Destroy(gameObject);

            }
        }
    }
}
