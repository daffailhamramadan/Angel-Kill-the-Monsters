using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource heartSFX;

    [SerializeField] private AudioSource hitSFX;

    [SerializeField] private AudioSource shotSFX;

    [SerializeField] private AudioSource bossLaugh;

    private void OnEnable()
    {
        PlayerHealth.playerGetHeart += HeartSFX;
        PlayerHealth.playerGetHit += HitSFX;
        PlayerShoot.playerShoot += ShotSFX;
        BossLaugh.bossLaugh += BossSFX;
    }

    private void OnDisable()
    {
        PlayerHealth.playerGetHeart -= HeartSFX;
        PlayerHealth.playerGetHit -= HitSFX;
        PlayerShoot.playerShoot -= ShotSFX;
        BossLaugh.bossLaugh -= BossSFX;
    }

    public void HeartSFX()
    {
        heartSFX.Play();
    }

    public void ShotSFX()
    {
        shotSFX.Play();
    }

    public void HitSFX()
    {
        hitSFX.Play();
    }

    public void BossSFX()
    {
        bossLaugh.Play();
    }
    
}
