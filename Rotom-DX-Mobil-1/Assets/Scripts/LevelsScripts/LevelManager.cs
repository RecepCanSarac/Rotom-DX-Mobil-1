using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [SerializeField] private List<Button> buttonList = new List<Button>();

    private int activeLevelIndex = 2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        LoadComplateLevels();
        CheckAllButton();
    }

    private void CheckAllButton()
    {
        for (int i = 0; i < buttonList.Count; i++)
        {
            if (activeLevelIndex >= buttonList[i].GetComponent<ButtonController>().buttonValue)
            {
                buttonList[i].GetComponent<ButtonController>().SetLockState();
            }
        }
    }
    private void LoadComplateLevels()
    {
        if (PlayerPrefs.GetInt(nameof(activeLevelIndex)) == 0)
        {
            activeLevelIndex = 2;
        }
        else
        {
            activeLevelIndex = PlayerPrefs.GetInt(nameof(activeLevelIndex));
        }
    }
    public void SaveActiveLevelIndex()
    {
        activeLevelIndex++;
        PlayerPrefs.SetInt(nameof(activeLevelIndex),activeLevelIndex);
    }

    [ContextMenu("Clear")]
    public void Clear()
    {
        PlayerPrefs.DeleteKey("activeLevelIndex");
    }
}
