using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilBehaviour : MonoBehaviour
{
    public float _speed = 0.65f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            Destroy(gameObject);

        }
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
