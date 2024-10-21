using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AmbientController : ControllerBase
{
    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public AudioMixer audioMixer;
    
    public AudioMixerSnapshot[] snapshots;
    
}