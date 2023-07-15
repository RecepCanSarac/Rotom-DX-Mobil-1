using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsDataSystem : MonoBehaviour
{
    public Button[] levels;
    public int changeNum;
    public int _indexBuildScene;
    void Start()
    {
        changeNum = 1;
        foreach (var level in levels)
        {
            level.interactable = false;
        }
    }
    void Update()
    {
        if (changeNum == _indexBuildScene)
        {
            for (int i = 0; i < changeNum; i++)
            {
                levels[changeNum].interactable = true;
            }
           
        }
    }
}
