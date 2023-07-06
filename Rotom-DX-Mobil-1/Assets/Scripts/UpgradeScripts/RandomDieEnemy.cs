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
        _enemyDector = FindObjectOfType<EnemyDedector>();


    }
    public void PlayerUpgrade()
    {
        RastgeleDusmanSil();
    }
    public void RastgeleDusmanSil()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);

        if (_enemyDector.dusmanlar.Count == 0)
            return;


        int rastgeleIndex = Random.Range(0, _enemyDector.dusmanlar.Count);
        GameObject rastgeleDusman = _enemyDector.dusmanlar[rastgeleIndex];


        _enemyDector.dusmanlar.Remove(rastgeleDusman);
        Destroy(rastgeleDusman);
    }
}
