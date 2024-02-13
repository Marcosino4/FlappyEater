using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class EyeBehaviour : MonoBehaviour
{
    public float _speed = 1.5f;
    public float _rotationSpeed = 10f;
    public static event Action onPlayerDeath;
    public GameObject deathEffect;
    public AudioSource explosion;

    private int movement = 0;
    private Animator _animator;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        movement = GameManager.instance.movement;
    }

    void Update()
    {
        if (transform.position.y > 3.5f)
        {
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
        }
        if (transform.position.y < -3.5f)
        {
            transform.position = new Vector3(transform.position.x, -3.5f, transform.position.z);
        }
        if (transform.position.x != -5f)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        //pc

        switch (movement)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Mouse0)))
                {

                    _rb.velocity = Vector2.up * _speed;
                }
                break;
            case 1:
                if (Input.GetKey(KeyCode.Space) || (Input.GetKey(KeyCode.Mouse0)))
                {

                    _rb.velocity = Vector2.up * (_speed - 1);
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Mouse0)))
                {

                    _rb.gravityScale *= -1;
                }
                break;

        }

#elif UNITY_ANDROID
        // movil

        foreach(Touch toque in Input.touches)
        {
        switch (movement)
        {
            case 0:
                if (toque.phase == TouchPhase.Began)
                {
                    _rb.velocity = Vector2.up * (_speed - 1);
                }
                break;
            case 1:
                if (toque.phase == TouchPhase.Stationary)
                {
                    _rb.velocity = Vector2.up * (_speed - 1);
                }
                break;
            case 2:
                if (toque.phase == TouchPhase.Began)
                {

                    _rb.gravityScale *= -1;
                }
                break;

        }

            
        }


#endif

    }

    private void FixedUpdate()
    {

        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed + 90);

    }

    private void Death()
    {
        explosion.Play();
        gameObject.SetActive(false);
        Instantiate(deathEffect, transform.position, transform.rotation);

    }
    private void SetRecord()
    {

        if (PlayerPrefs.GetInt("record", 0) < Score.instance.GetScore())
        {

            PlayerPrefs.SetInt("record", Score.instance.GetScore());
        }
        Record.instance.SetRecord();
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
            SetRecord();
            onPlayerDeath?.Invoke();
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
