using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private GameObject LockObj;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private Button btn;

    int levelIndex;
    private void Start()
    {
        btn.onClick.AddListener(()=>OnButtonClick());
    }
    public void LevelEditFNC(LevelItem levelItem, int index)
    {
        if (levelItem.isItUnlocked)
        {
            levelIndex = index + 1;
            btn.interactable = true;
            LockObj.SetActive(false);
            levelTxt.text = levelIndex.ToString();
        }
        else
        {
            btn.interactable = false;
            LockObj.SetActive(true);
            levelTxt.text = "";
        }
    }

    void OnButtonClick()
    {
        LevelSystemManager.instance.levelIndex = levelIndex - 1;
        SceneManager.LoadScene("level" + levelIndex);
    }
}
