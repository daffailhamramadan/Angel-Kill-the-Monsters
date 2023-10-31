using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;

    [SerializeField] private PlayerHealth playerHealth;

    [SerializeField] private GameObject Finish;

    private void OnEnable()
    {
        BossDeath.bossDeath += Win;
    }

    private void OnDisable()
    {
        BossDeath.bossDeath -= Win;
    }

    private void Start()
    {
        Finish.SetActive(false);
    }

    private void Win()
    {
        Finish.SetActive(true);
    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < playerHealth.currentHealth)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }
}
