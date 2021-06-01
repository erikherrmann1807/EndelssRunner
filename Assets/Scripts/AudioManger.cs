using UnityEngine;
using UnityEngine.UI;

public class AudioManger : MonoBehaviour {
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string volumePref = "volumePref";
    public Slider volumeSlider;
    public AudioSource[] soundEffectsAudio;
    private int firstPlayInt;
    private float volumeFloat;

    public void SaveSoundSettings() {
        PlayerPrefs.SetFloat(volumePref, volumeSlider.value);
    }

    public void UpdateSound() {
        for (int i = 0; i < soundEffectsAudio.Length; i++) soundEffectsAudio[i].volume = volumeSlider.value;
    }

    // Start is called before the first frame update
    private void Start() {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0) {
            volumeFloat = .75f;
            volumeSlider.value = volumeFloat;
            PlayerPrefs.SetFloat(volumePref, volumeFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else {
            volumeFloat = PlayerPrefs.GetFloat(volumePref);
            volumeSlider.value = volumeFloat;
        }
    }

    private void OnApplicationFocus(bool inFocus) {
        if (!inFocus) SaveSoundSettings();
    }
}