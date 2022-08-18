using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack: MonoBehaviour
{
    private WeaponHandler weapon_Handler;

    public float fireRate = 1f;
    private float nextTimeToFire = 0f;
    public float damage = 20f;

    [SerializeField]
    private GameObject bullet_Prefab;
    //??? How to rotate bullet_Prefab using transform.rotation

    [SerializeField]
    private Transform Bullet_Start_Position;

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
        // Bullet_Start_Position.LookAt(target);
    }


    void WeaponShoot()
    {
        if (Time.time > nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            weapon_Handler.ShootAnimation();
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bullet_Prefab);
        Rigidbody body = bullet.GetComponent<Rigidbody>();
        body.transform.position = Bullet_Start_Position.position;
        body.transform.rotation = Bullet_Start_Position.rotation;
        BulletScript x = bullet.GetComponent<BulletScript>();
        x.EnemyLaunch(target);
        body.AddForce(bullet.transform.forward * 20, ForceMode.Impulse);
    }
    /*    void Shoot()
        {
            GameObject bullet = Instantiate(bullet_Prefab);
            bullet.transform.position = Bullet_Start_Position.position;
            BulletScript x = bullet.GetComponent<BulletScript>();
            Debug.Log(bullet);
            x.Launch();
        }
    */
}