using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnRocket;
    public GameObject rocketLauncher;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void EndShooting()
    {
        rocketLauncher.GetComponent<Animator>().SetBool("Shoot", false);
        Instantiate(spawnRocket, spawnPoint.transform.position, spawnPoint.transform.rotation);

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            rocketLauncher.GetComponent<Animator>().SetBool("Shoot", true);

            Invoke(nameof(EndShooting), 0.3f);
        }

    }
}
