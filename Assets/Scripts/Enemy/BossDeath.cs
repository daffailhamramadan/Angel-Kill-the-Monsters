using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath : MonoBehaviour
{
    private EnemyHealth enemyHealth;

    public delegate void BossDeathEvent();

    public static event BossDeathEvent bossDeath;

    public static bool Finish;

    private void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        Finish = false;
    }

    private void Update()
    {
        if (enemyHealth.currentHealth <= 0)
        {
            Finish = true;
            bossDeath?.Invoke();
            Destroy(gameObject);
        }
    }
}
