using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private EnemyHealth enemyHealth;

    [SerializeField] private GameObject hearts;

    private float randomValue;

    private void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Start()
    {
        randomValue = Random.value;
    }

    private void Update()
    {
        if(enemyHealth.currentHealth <= 0)
        {
            if(randomValue < 0.5f)
            {
                Instantiate(hearts, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

}
