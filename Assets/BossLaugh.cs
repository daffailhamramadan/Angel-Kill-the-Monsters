using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLaugh : MonoBehaviour
{
    private CheckPlayer checkPlayer;

    public delegate void Laugh();

    public static event Laugh bossLaugh;

    private void Awake()
    {
        checkPlayer = GetComponent<CheckPlayer>();
    }

    private void Update()
    {
        if (checkPlayer.IsPlayerNearby)
        {
            bossLaugh?.Invoke();
        }

    }
}
