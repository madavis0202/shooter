/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    private WeaponHandler weapon_Handler;

    public float fireRate = 1f;
    private float nextTimeToFire;
    public float damage = 20f;

    [SerializeField]
    private GameObject bullet_Prefab;
    //??? How to rotate bullet_Prefab using transform.rotation

    [SerializeField]
    private Transform bullet_Start_Position;

    public Transform target;

    private void Awake()
    {
        weapon_Handler = GetComponent<WeaponHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WeaponShoot();
        transform.LookAt(target);
    }


    void WeaponShoot()
    {
        if (weapon_Handler.fireType == WeaponFireType.MULTIPLE)
        {

            if (Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                weapon_Handler.ShootAnimation();
                Shoot();
            }
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bullet_Prefab);
        bullet.transform.position = bullet_Start_Position.position;
        BulletScript x = bullet.GetComponent<BulletScript>();
        Debug.Log(bullet);
        x.Launch();
    }
    
}*/