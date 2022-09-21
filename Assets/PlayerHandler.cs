using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public int HP = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
