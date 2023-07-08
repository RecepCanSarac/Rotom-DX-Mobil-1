using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeDown : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }

    public void PlayerUpgrade()
    {
        TimeSlow();
    }

    private void TimeSlow()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);

        Time.timeScale = 0.5f;
        _playerMove.speed *= 2.0f;
    }
}
