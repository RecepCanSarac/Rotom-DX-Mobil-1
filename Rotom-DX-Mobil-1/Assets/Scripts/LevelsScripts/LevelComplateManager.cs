using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class LevelComplateManager : MonoBehaviour
{
    private Button levelComplateButton;

    private void Start()
    {
        levelComplateButton = GetComponent<Button>();
        levelComplateButton.onClick.AddListener(LevelComplate);
    }
    public void LevelComplate()
    {
        if (PlayerPrefs.GetInt("activeLevelIndex") <= SceneManager.GetActiveScene().buildIndex)
        {
            LevelManager.instance.SaveActiveLevelIndex();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
