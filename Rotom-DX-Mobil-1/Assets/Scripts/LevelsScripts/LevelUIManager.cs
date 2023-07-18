using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUIManager : MonoBehaviour
{
    [SerializeField] private Transform btnHolder;
    [SerializeField] private ButtonManager btnPrefab;
    private void Start()
    {
        StartFunc();
    }
    void StartFunc()
    {
        LevelItem[] levelITemArray = LevelSystemManager.instance.levelData.levelItemArray;

        for (int i = 0; i < levelITemArray.Length; i++)
        {
            ButtonManager levelBtn = Instantiate(btnPrefab, btnHolder);
            levelBtn.LevelEditFNC(levelITemArray[i],i);
        }
    }
}
