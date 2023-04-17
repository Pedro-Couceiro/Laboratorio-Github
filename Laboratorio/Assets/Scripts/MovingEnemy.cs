using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    [SerializeField] private float Range;
<<<<<<< HEAD


    // Start is called before the first frame update
    void Start()
    {
        
=======
    private GameObject player;
    private float location;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Teste");
        if (collision.CompareTag("Player"))
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
        }
            
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
>>>>>>> main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
       
>>>>>>> main
    }
}
