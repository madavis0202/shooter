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

    private void OnCollisionEnter(Collision collision)
    {
	HP -= 1;
	Debug.Log(HP);
	if (HP <= 0) {
            SceneManager.LoadScene("Test", LoadSceneMode.Single);
        }
    }
}
