using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private bool Death;
    public GameObject Player;
    public GameObject refer;
    public Transform Spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.activeSelf)
        {
           // Death = true;
           // StartCoroutine(Respawn());
        }
    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);
        //Player = Instantiate(refer, Spawn.position, Spawn.rotation);
        //Player.AddComponent<BulletDie>();
        
    }
}

