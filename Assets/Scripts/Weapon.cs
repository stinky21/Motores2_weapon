using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_prefabs : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PF_Bullet;
    public Transform spawnPoint;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(PF_Bullet);
            newBullet.transform.position = spawnPoint.position;
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 100.0f);
        }
    }
}
