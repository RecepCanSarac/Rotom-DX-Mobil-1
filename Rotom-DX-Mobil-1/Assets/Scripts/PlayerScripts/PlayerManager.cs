using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerData[] playerDatas = new PlayerData[10];
    private EnemyScripts _enemyScripts;
    private SpriteRenderer playerSprite;
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
       
    }

   

}
