using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranbolinScript : MonoBehaviour,IController
{
    private PlayerMove _playerMove;
    private UpgradeData _upgradeData;
    private EnemyScripts _enemyScript;
    public GameObject _tranbolin1;
    public GameObject _tranbolin2;
    void Start()
    {
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
       
    }
    public void PlayerUpgrade()
    {
        Tranbolin();
    }
    private void Tranbolin()
    {
        _upgradeData.ActiveUpgrade(_enemyScript.spacialNum);

        Instantiate(_tranbolin1,new Vector2(3.75f,-4.95f),Quaternion.identity);
        Instantiate(_tranbolin2,new Vector2(-3.75f,-4.95f),Quaternion.identity);
        
    }
}
