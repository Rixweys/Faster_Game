using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolueValume : MonoCache
{

    private AudioSource audioScr;
    private float musicVolume = 0.3f;
    
    void Start()
    {
        audioScr = GetComponent<AudioSource>();
    }

    // справка 3
    public override void OnTick()
    {
        audioScr.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
