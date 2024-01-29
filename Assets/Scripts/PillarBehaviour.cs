using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -10)
        {
            gameObject.SetActive(false);
        }
        transform.position += Vector3.left * _speed * Time.deltaTime;  
    }
}
