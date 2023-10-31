using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private ParticleSystem damageEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Wall"))
        {
            Instantiate(damageEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("DoorCheck"))
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
