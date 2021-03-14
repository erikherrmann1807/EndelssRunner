using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{

    private static readonly string volumePref = "volumePref";
    private float volumeFloat;
    public AudioSource[] soundEffectsAudio;

    // Start is called before the first frame update
    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        volumeFloat = PlayerPrefs.GetFloat(volumePref);

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = volumeFloat;
        }
    }
}
