using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    private Transform spawnBugPos;
    [SerializeField] private GameObject bugPrefab;
    void Start()
    {
        spawnBugPos = GameObject.FindGameObjectWithTag("SpawnPoint").transform;
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }

    public void PlayerUpgrade()
    {
        BugGenerator();
    }

    private void BugGenerator()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);
        _playerMove.speed = 425;
        Instantiate(bugPrefab,spawnBugPos.position,Quaternion.identity);
    }
}
