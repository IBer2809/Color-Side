using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SgLib;

public class AudioScript : MonoBehaviour
{
    public AudioSource audiostart;
    public AudioSource audiocubedestruction;
    public AudioSource audiodiamonddestruction;
    public AudioSource audiofailure;
    public AudioSource click;
    public AudioSource firework;


    public void AudioStart()
    {
        audiostart.Play();
    }

    public void AudioCubeDestruction()
    {
        audiocubedestruction.Play();
    }
    public void AudioDiamondDestruction()
    {
        audiodiamonddestruction.Play();
    }
    public void AudioFailureDestruction()
    {
        audiofailure.Play();
    }

    public void Click()
    {
        click.Play();
    }
    public void Firework()
    {
        firework.Play();
    }
}
