using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystemManager : MonoBehaviour
{
    public static LevelSystemManager instance;

    public int levelIndex;

    public LevelData levelData;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        SaveDataManager.Instance.StartFNC();
    }

   

    public void ComplateLevel()
    {
        if(levelData.lastUnlockedLevel < (levelIndex + 3))
        {
            levelData.lastUnlockedLevel = levelIndex + 1;
            levelData.levelItemArray[levelData.lastUnlockedLevel].isItUnlocked = true;
            SaveDataManager.Instance.DataSaveFNC();
        }  
    }
}
