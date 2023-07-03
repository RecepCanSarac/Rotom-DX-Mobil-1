using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UpgradeData : MonoBehaviour
{
    [Header("PlayerSprite")]
    [SerializeField] private Sprite[] _sprite;

    [Header("PlayerUpgrade")]
    [SerializeField] public GameObject[] _upgradeScripts;

    private EnemyScripts _enemyScripts;

    private void Start()
    {
        _enemyScripts = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
    }

    private void Update()
    {
        if (_enemyScripts.die == true)
        {
            for (int i = 0; i < _upgradeScripts.Length; i++)
            {
                if (i == _enemyScripts.spacialNum)
                {
                    _upgradeScripts[i].gameObject.SetActive(true);
                    Debug.Log("Bu budur" + i);
                }
                else
                {
                    _upgradeScripts[i].gameObject.SetActive(false);
                    Debug.Log("Hatalý");
                 
                }
            }
            _enemyScripts.die = false;
        }
       
    }
}
