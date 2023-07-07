using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untouchable : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    private BoxCollider2D _player;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>();
    }

    public void PlayerUpgrade()
    {
        Untouchable();
    }

    private void Untouchable()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);
        _player.isTrigger = true;
        _playerMove.speed = 0;
    }
}
