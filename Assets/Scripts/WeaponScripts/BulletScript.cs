using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody myBody;

    public float speed = 30f;

    public float deactivate_Timer = 3f;

    public float damage = 15f;


    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();

    }
    // Start is called before the first frame update
    void Start()
    {

        Invoke("DeactivateGameObject", deactivate_Timer);
    }
    void DeactivateGameObject()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }
    
    public void Launch()
    {

        myBody.velocity = Camera.main.transform.forward * speed;

        transform.LookAt(transform.position + myBody.velocity);
    }
    public void EnemyLaunch(Transform target)
    {
        transform.LookAt(target.transform.position);
        Debug.Log(target);
    }
    void OnTriggerEnter(Collider target)
        {
        
        }
        
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
