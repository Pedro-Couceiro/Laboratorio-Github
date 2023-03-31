using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeDestroy : MonoBehaviour
{
    private float age;

    [SerializeField] private float life;

    void Start()
    {
        age = 0;
    }

    // Update is called once per frame
    void Update()
    {
        age += Time.deltaTime;

        if(age > life)
        {
            Destroy(gameObject);
        }
    }
}
