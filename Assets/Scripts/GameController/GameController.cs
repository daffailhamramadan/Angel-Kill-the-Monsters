using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;

    private void Update()
    {
        if(playerHealth.currentHealth <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
