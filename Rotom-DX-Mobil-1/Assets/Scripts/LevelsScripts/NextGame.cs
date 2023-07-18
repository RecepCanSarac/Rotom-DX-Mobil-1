using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGame : MonoBehaviour
{
   public void gameNext()
    {
     
        SceneManager.LoadScene(1);
    }
}
