using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncherBehaviour : MonoBehaviour
{
    public GameObject deathAnim;

    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Death()
    {
        Instantiate(deathAnim, transform.position, transform.rotation);
        gameObject.SetActive(false);
        Score.Instance.addPoints();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(Death), 0.2f);
        }
    }
}
