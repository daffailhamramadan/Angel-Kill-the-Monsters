using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    [SerializeField] private Transform areaCheckPlayer;

    public bool IsPlayerNearby;

    public LayerMask player;

    private void Update()
    {
        if (Physics2D.OverlapBox(areaCheckPlayer.position, new Vector3(17f,7f), 0f, player))
        {
            IsPlayerNearby = true;
        }
        else
        {
            IsPlayerNearby = false;
        }

      
    }
}
