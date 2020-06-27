using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    public int Hits = 0;
    public GameObject Player;
    void Update()
    {
        if(Hits >= 2)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Hits += 1;
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Player);
        }
    }

}
