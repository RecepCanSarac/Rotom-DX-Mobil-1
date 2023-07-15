using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneNumber : MonoBehaviour
{
    public LevelsDataSystem system;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel()
    {
        system._indexBuildScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(1);
    }
}
