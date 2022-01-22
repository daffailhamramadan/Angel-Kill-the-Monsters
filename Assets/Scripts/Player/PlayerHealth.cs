using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;

    [SerializeField] private float maxHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth =  Mathf.Clamp(currentHealth, 0f, maxHealth);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}
