using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EyeMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
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
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed + 90);

    }

    private void Die()
    {

    }

    private void Eat()
    {

    }

    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.gameObject.CompareTag("Pillar"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("RockerLauncher"))
        {
            Eat();
        }
        if (collision.gameObject.CompareTag("Rocket"))
        {

        }
    }
}
