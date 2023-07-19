using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;



    public void LevelComplate()
    {
        levelText.text = "Level" + (LevelSystemManager.instance.levelIndex + 1) + "Tamamlandý";
        LevelSystemManager.instance.ComplateLevel();
        SceneManager.LoadScene(1);
    }

 
}
