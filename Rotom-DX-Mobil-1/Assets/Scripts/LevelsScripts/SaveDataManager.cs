using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    public static SaveDataManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartFNC()
    {
        int oyunIlkAcildi = PlayerPrefs.GetInt("oyunIlkAcildi", 0);

        if (oyunIlkAcildi == 2)
        {
            DataLoadFNC();
        }
        else
        {
            DataSaveFNC();
            PlayerPrefs.SetInt("oyunIlkAcildi", 2);
        }
    }
    


    public void DataSaveFNC()
    {
        string levelDataString = JsonUtility.ToJson(LevelSystemManager.instance.levelData);

        try
        {
            System.IO.File.WriteAllText(Application.persistentDataPath + "/LevelData.json",levelDataString);
        }
        catch (System.Exception e)
        {
            print("Kayýtta hata oluþtu" + e);
            throw;
        }
    }

    void DataLoadFNC()
    {
        try
        {
            string levelDataString = System.IO.File.ReadAllText(Application.persistentDataPath + "/LevelData.json");

            LevelData levelData = JsonUtility.FromJson<LevelData>(levelDataString);

            if (levelData != null)
            {
                LevelSystemManager.instance.levelData.levelItemArray = levelData.levelItemArray;
                LevelSystemManager.instance.levelData.lastUnlockedLevel = levelData.lastUnlockedLevel; 
            }
        }
        catch (System.Exception e)
        {
            print("Yüklemede hata oluþtu" + e);
            throw;
        }
    }
}
