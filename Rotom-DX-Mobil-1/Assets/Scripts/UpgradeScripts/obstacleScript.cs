using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour,IController
{
    [SerializeField] private GameObject obstacle;
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    public Vector2 ýnsPoint;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }

    public void PlayerUpgrade()
    {
        InstantiateObstacle();
    }

    private void InstantiateObstacle()
    {
       
        GameObject obstacleIns = Instantiate(obstacle, ýnsPoint, Quaternion.identity);
    }
}
