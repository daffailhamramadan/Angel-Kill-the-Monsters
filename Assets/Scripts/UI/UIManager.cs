using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;

    [SerializeField] private PlayerHealth playerHealth;

    private void Update()
    {
        if(playerHealth.currentHealth == 2)
        {
            hearts[2].SetActive(false);
        }

        if (playerHealth.currentHealth == 1)
        {
            hearts[1].SetActive(false);
        }

        if (playerHealth.currentHealth == 0)
        {
            hearts[0].SetActive(false);
        }
    }
}
