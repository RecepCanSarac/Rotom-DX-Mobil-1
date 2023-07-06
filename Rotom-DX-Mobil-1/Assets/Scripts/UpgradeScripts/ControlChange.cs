using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChange : MonoBehaviour,IController
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
        ChangeControl();
    }

    private void ChangeControl()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);
        _playerMove.speed *= -1;
    }
}
