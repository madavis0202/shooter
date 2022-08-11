using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    Vector3 velocity = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Mathf.Abs(x) != 1)
        {
            x = 0f;
        }
        if (Mathf.Abs(z) != 1)
        {
            z = 0f;
        }

        Vector3 move = transform.right * x;
        controller.Move(move * speed * Time.deltaTime);
    }
}
