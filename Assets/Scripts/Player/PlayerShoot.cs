using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private PlayerInput playerInput;

    private Vector3 mousePosition;

    private Vector3 shootDirection;

    [SerializeField] private GameObject bullet;

    private Rigidbody2D rigidBody;

    public float angle;

    public delegate void PlayerShootEvent();

    public static event PlayerShootEvent playerShoot;

    private void Awake()
    {
        mainCamera = Camera.main;

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        shootDirection = mousePosition - transform.position;

        if (playerInput.LeftMouse())
        {
            playerShoot?.Invoke();
        }

    }

    private void OnEnable()
    {
        playerShoot += Shoot;
    }

    private void OnDisable()
    {
        playerShoot -= Shoot;
    }



    private void Shoot()
    {
        GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity);

        Rigidbody2D rb = bullets.GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(shootDirection.normalized.x, shootDirection.normalized.y) * 50f;
    }
}
