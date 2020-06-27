using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool Fire = true;
    public int bullets = 0;
    public float bulletForce = 20f;

    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
            if (Fire == true)
            {

                if(bullets >= 5)
                {
                    Fire = false;
                    StartCoroutine(BallCoroutine());
                }

                if (bullets <= 5)
                {
                    ShootGun();
                }
                bullets += 1;
            }
            
        }

    }

    void ShootGun()
    {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            bullet.AddComponent<BulletDie>();
    }
    IEnumerator BallCoroutine()
    {     
        yield return new WaitForSeconds(1f);
        Fire = true;
        bullets = 0;
    }
    
}
