using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] private float explosionRadius;
    private float _countdown;
    public float countdownEnd;

    void Start()
    {
        _countdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _countdown += Time.deltaTime;

        if(_countdown >= countdownEnd)
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

            foreach (Collider2D collider in colliders)
            {
                EnemyScript enemy = collider.GetComponent<EnemyScript>();
                if (enemy != null)
                {
                    Destroy(collider.gameObject);
                }
            }

            Destroy(gameObject);
        }
    }
}

