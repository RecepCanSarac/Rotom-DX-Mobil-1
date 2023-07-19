using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;

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
        int oyunIlkAcildi = PlayerPrefs.GetInt("oyunIlkAcildi", 1);

        if (oyunIlkAcildi == 4)
        {
            DataLoadFNC();
        }
        else
        {
            DataSaveFNC();
            PlayerPrefs.SetInt("oyunIlkAcildi", 4);
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
            print("Kay�tta hata olu�tu" + e);
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
            print("Y�klemede hata olu�tu" + e);
            throw;
        }
    }
    public void DeleteData()
    {
        try
        {
            string filePath = Application.persistentDataPath + "/LevelData.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                print("Veriler silindi.");
            }
            else
            {
                print("Silinecek veri dosyas� bulunamad�.");
            }
        }
        catch (System.Exception e)
        {
            print("Silme i�lemi s�ras�nda hata olu�tu: " + e);
            throw;
        }
    }
}
