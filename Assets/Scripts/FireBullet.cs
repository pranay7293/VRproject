using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed = 20f;
    
    public void FiringBullet()
    {
        GameObject gameObject = 
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        gameObject.GetComponent<Rigidbody>().velocity = 
            spawnPoint.forward * bulletSpeed;
        Destroy(gameObject, 4f);

        Debug.Log("BulletSpawned");
    }
}
