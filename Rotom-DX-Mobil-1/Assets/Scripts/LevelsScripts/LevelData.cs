
using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class LevelData 
{
    public int lastUnlockedLevel = 2;

    public LevelItem[] levelItemArray;
}
[System.Serializable]
public class LevelItem
{
    public bool isItUnlocked;
}
