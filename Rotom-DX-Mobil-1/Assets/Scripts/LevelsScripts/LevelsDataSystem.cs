using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsDataSystem : MonoBehaviour
{
    public static int levelSceneNum;
    public int bigLevelDatanum;
    void Start()
    {
        bigLevelDatanum = PlayerPrefs.GetInt(nameof(bigLevelDatanum));
    }


    void Update()
    {
        levelSceneNum = SceneManager.GetActiveScene().buildIndex;
        bigLevelDatanum = levelSceneNum;
        PlayerPrefs.SetInt(nameof(bigLevelDatanum), bigLevelDatanum);
        if (levelSceneNum > bigLevelDatanum)
        {
            bigLevelDatanum = levelSceneNum;
        }
        else if (levelSceneNum < bigLevelDatanum)
        {
            return ;
        }
        Debug.Log("BüyükLevel" + bigLevelDatanum);
        Debug.Log("Þuanki Level" + levelSceneNum);
    }
}
