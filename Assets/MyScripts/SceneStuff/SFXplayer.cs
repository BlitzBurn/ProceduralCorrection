using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXplayer : MonoBehaviour
{
    public AudioSource jumpSound;
    public AudioSource crashSound;
    public AudioSource gameOverSound;
    public AudioSource buttonSound;
    public AudioSource moveBlockSound;
    public AudioSource landingSound;
    public AudioSource fallToYourDeathSound; 

    public void PlayJumpSound()
    {
        jumpSound.Play();
    }

    public void PlayCrashSound()
    {
        crashSound.Play();
    }

    public void PlayGameOverSound()
    {
        gameOverSound.Play();
    }

    public void PlayButtonSound()
    {
        buttonSound.Play();
    }

    public void PlayMoveBlockSound()
    {
        moveBlockSound.Play();
    }

    public void PlayLandingSound()
    {
        landingSound.Play();
    }

    public void PlayFallToYourDeathSound()
    {
        fallToYourDeathSound.Play();
    }
}
