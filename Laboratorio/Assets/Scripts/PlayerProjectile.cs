using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private float _damage;
    
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime,0,0);
    }

    /*public void  Reverse()
    {
        _speed -= -1;
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyScript>().TakeDamage(_damage);
        }
    }
}
