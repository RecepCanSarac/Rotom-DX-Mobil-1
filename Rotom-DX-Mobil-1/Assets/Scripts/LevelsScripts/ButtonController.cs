using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    private Button levelButton;

    [SerializeField] private Text buttonText;
    [SerializeField] private GameObject buttonLockObject;
    public int buttonValue;
    private bool isComplate;
    void Start()
    {
        levelButton = GetComponent<Button>();
        levelButton.onClick.AddListener(LoadSelectedScene);
    }
    public void SetLockState()
    {
        isComplate = true;
        if (isComplate)
        {
            buttonText.text = (buttonValue - 1).ToString();
            buttonLockObject.SetActive(false);
        }
        else
        {
            buttonText.text = "";
            buttonLockObject.SetActive(true);
        }
    }

    public void LoadSelectedScene()
    {
        if (isComplate)
        {
            SceneManager.LoadScene(buttonValue);
        }
    }

    
}
