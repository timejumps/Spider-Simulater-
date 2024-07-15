using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource soundPlay;

    public void PlayThisSoundEffect()
    {
        soundPlay.Play();
    }
}
