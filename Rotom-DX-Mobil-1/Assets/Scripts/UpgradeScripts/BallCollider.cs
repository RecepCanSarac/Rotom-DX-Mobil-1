using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;

    private CircleCollider2D _boxCollider;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
        _boxCollider = GameObject.FindGameObjectWithTag("Ball").GetComponent<CircleCollider2D>();
    }
    public void PlayerUpgrade()
    {
        ColliderBall();
    }

    private void ColliderBall()
    {
        
        _boxCollider.isTrigger = true;
    }
}