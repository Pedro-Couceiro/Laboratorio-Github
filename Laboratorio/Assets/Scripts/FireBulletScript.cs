using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletScript : MonoBehaviour
{
    [SerializeField] private GameObject _SpawnPrefab;
    private float spawnTime;
    public float timeInterval;

    void Start()
    {
        spawnTime = 0;
    }


    void Update()
    {
        spawnTime += Time.deltaTime;
        if(spawnTime >= timeInterval)
        {
            GameObject newGameObject = Instantiate(_SpawnPrefab);
            newGameObject.transform.position = transform.position;
            spawnTime = 0;
        }
    }
}
