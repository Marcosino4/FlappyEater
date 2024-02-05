using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EyeBehaviour : MonoBehaviour
{
    public float _speed = 1.5f;
    public float _rotationSpeed = 10f;

    public GameObject deathEffect;

    private Animator _animator;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Mouse0)))
        {

            _rb.velocity = Vector2.up * _speed;


        }
        if(transform.position.x != -5f)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 3.5f)
        {
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
        }
        if (transform.position.y < -3.5f)
        {
            transform.position = new Vector3(transform.position.x, -3.5f, transform.position.z);
        }

    }

    private void FixedUpdate()
    {

        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed + 90);

    }

    private void Death()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void StopBite()
    {
        _animator.SetBool("Bite", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pillar") || collision.gameObject.CompareTag("Rocket"))
        {
            Death();
        }
        if (collision.gameObject.CompareTag("RocketLauncher"))
        {

            _animator.SetBool("Bite", true);

            Invoke(nameof(StopBite), 0.2f);

           

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RocketLauncher"))
        {
            _animator.SetBool("Bite", false);
        }
    }
}
