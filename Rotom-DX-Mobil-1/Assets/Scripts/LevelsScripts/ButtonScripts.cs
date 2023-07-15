using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void NextLevel(int number)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + number);
    }
}
