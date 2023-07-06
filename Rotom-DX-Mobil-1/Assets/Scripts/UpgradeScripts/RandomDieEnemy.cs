using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDieEnemy : MonoBehaviour, IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    private EnemyDedector _enemyDector;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }
    public void PlayerUpgrade()
    {
        RandomDie();
    }
    private void RandomDie()
    {
        _enemyDector = GameObject.FindGameObjectWithTag("Detected").GetComponent<EnemyDedector>();
        int random = Random.Range(0, _enemyDector.dusmanlar.Count);

    }
}
