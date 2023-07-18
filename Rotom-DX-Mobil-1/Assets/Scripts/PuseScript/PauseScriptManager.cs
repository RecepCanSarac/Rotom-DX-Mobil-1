using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScriptManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    public void PausePanelActive()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void PausePanalDeActive()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LevelsMenu()
    {
        SceneManager.LoadScene(1);
    }
}
