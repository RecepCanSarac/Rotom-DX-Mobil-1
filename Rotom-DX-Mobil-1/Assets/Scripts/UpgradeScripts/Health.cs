using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    [SerializeField] private int MaxHealth;
    private void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }

    public void PlayerUpgrade()
    {
        PlayerHealthPlus();
       
    }

    private void PlayerHealthPlus()
    {
       
        _playerMove.health = MaxHealth;
        Debug.Log("Can Arttý");
    }
}
