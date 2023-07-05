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
    
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _enemyScripts = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScripts>();
       _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ActiveUpgrade(int specialNum)
    {
        for (int i = 0; i < _sprite.Length; i++)
        {
            if (specialNum == i)
            {
                _spriteRenderer.sprite = _sprite[i];    
                Debug.Log("Active");
            }
        }
    }
}
