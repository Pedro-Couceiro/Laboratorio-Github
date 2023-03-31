using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float _enemyLives;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float playerDamage)
    {
        Debug.Log("Enemy HP: " + _enemyLives);
        _enemyLives -= playerDamage;

        if(_enemyLives <= 0)
        {
            Destroy(gameObject);

            Debug.Log("it is dead");
        }
    }
}
