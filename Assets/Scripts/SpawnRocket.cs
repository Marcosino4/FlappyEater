using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnRocket;
    public GameObject spawnRecoil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Instantiate(spawnRocket, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Instantiate(spawnRecoil, new Vector3(transform.position.x ,transform.position.y - 3.5f, transform.position.z), transform.rotation);

        }
        
    }
}
