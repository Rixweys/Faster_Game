using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolueValume : MonoCache
{

    private AudioSource audioScr;
    private float musicVolume = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public override void OnTick()
    {
        audioScr.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
