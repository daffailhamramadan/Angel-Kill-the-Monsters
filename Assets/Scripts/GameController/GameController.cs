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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
