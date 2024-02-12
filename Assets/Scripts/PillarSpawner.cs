using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{

    public float maxTime;
    public GameObjectPool gameObjectPool;

    private float _maxHeight = 1;
    private float _minHeight = -4;
    private float currentTime;

    void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            GameObject pillar = gameObjectPool.GetInactiveGameObject();

            if (pillar)
            {
                pillar.SetActive(true);
                pillar.transform.GetChild(1).gameObject.SetActive(true);    
                pillar.transform.position = new Vector3(transform.position.x, Random.Range(_maxHeight, _minHeight), 0);
            }

            currentTime = 0;
        }
    }
}
