using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }
    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "GameOver")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Debug.Log(Cursor.lockState);
            Debug.Log(Cursor.visible);
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
