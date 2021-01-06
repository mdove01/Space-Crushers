using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreenIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
