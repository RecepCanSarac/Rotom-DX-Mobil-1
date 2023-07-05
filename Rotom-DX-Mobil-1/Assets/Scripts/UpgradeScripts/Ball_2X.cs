using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_2X : MonoBehaviour,IController
{
    private Transform ball;
    private GameObject ballPrefab;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScripts;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").transform;
        ballPrefab = GameObject.FindGameObjectWithTag("Ball");
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScripts = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();

    }
    private void Ball2X()
    {
        _upgradeData.ActiveUpgrade(_enemyScripts.spacialNum);
        Instantiate(ballPrefab, ball.position, Quaternion.identity);
       
    }

    public void PlayerUpgrade()
    {
        Ball2X();
    }
}
