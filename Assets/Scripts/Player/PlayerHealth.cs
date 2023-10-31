using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector] public float currentHealth;

    [SerializeField] private float maxHealth;

    public delegate void PlayerGetHeart();

    public static event PlayerGetHeart playerGetHeart;

    public delegate void PlayerGetHit();

    public static event PlayerGetHit playerGetHit;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    private void Start()
    {
        currentHealth = 3;
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth =  Mathf.Clamp(currentHealth, 0f, maxHealth);
        
    }

    private void GetHeart(int health)
    {
        currentHealth += health;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(1);
            playerGetHit?.Invoke();
            StartCoroutine(GetHit());
        }

        if (collision.CompareTag("Heart"))
        {
            GetHeart(1);

            playerGetHeart?.Invoke();

            Destroy(collision.gameObject);
        }
    }

    IEnumerator GetHit()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }
}
