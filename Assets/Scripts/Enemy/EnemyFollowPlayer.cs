using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    private Transform player;

    private CheckPlayer checkPlayer;

    [SerializeField] private float speed;

    private Vector2 startPosition;

    public bool stopFollow;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();

        checkPlayer = GetComponentInChildren<CheckPlayer>();

        startPosition = transform.position;
    }

    private void Update()
    {
        if (checkPlayer.IsPlayerNearby)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else if(checkPlayer.IsPlayerNearby == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);
        }
    }
}
