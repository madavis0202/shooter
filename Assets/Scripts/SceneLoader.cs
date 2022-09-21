using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    void Start()
    {
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
