using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public int HP = 5;
    private float ShakeTimeRemaining, shakePower;
    void Restart()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
    private void OnCollisionEnter(Collision collision)
    {
	HP -= 1;
	if (HP <= 0) {
            HP = 5;
            Invoke("Restart", 0f);
        }
    }
}
