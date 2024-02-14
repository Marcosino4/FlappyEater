using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnRocket;
    public GameObject rocketLauncher;

    public void EndShooting() //Stop shooting for not being in loop
    {
        rocketLauncher.GetComponent<Animator>().SetBool("Shoot", false);
        Instantiate(spawnRocket, spawnPoint.transform.position, spawnPoint.transform.rotation);

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player")) //Shoot when player enters trigger
        {
            rocketLauncher.GetComponent<Animator>().SetBool("Shoot", true);

            Invoke(nameof(EndShooting), 0.3f);
        }

    }
}
