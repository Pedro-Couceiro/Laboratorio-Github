using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lifes : MonoBehaviour
{
    [SerializeField] private float Lives;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        Lives -= _damage;
        Debug.Log("Hit. Lives = " + Lives + "");

        string animation = "HurtAnim";

        if (Lives <= 0)
        {
            Destroy(gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        _animator.Play(animation);
    }
}
