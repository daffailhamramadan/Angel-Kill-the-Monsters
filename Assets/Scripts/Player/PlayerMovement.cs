using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput playerInput;

    private Rigidbody2D rigidBody;

    [SerializeField] private float speed;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(playerInput.Horizontal, playerInput.Vertical) * speed;

        rigidBody.velocity = move;
    }
}
