using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManger : MonoBehaviour
{

    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string volumePref = "volumePref";
    private int firstPlayInt;
    public Slider volumeSlider;
    private float volumeFloat;
    public AudioSource[] soundEffectsAudio;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {
            volumeFloat = .75f;
            volumeSlider.value = volumeFloat;
            PlayerPrefs.SetFloat(volumePref, volumeFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            volumeFloat = PlayerPrefs.GetFloat(volumePref);
            volumeSlider.value = volumeFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(volumePref, volumeSlider.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        if(!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = volumeSlider.value;
        }
    }
}
