using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PauseManager : MonoBehaviour
{
    public AudioMixerSnapshot menuSnapshot;


    public void Pause()
    {
        menuSnapshot.TransitionTo(0.1f);
        Time.timeScale = 0.1f;
    }

    public void UnPause()
    {
        Time.timeScale = 1;

    }
}
