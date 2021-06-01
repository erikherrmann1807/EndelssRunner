using UnityEngine;

public class AudioSettings : MonoBehaviour {
    private static readonly string volumePref = "volumePref";
    public AudioSource[] soundEffectsAudio;
    private float volumeFloat;

    // Start is called before the first frame update
    private void Awake() {
        ContinueSettings();
    }

    private void ContinueSettings() {
        volumeFloat = PlayerPrefs.GetFloat(volumePref);

        for (int i = 0; i < soundEffectsAudio.Length; i++) soundEffectsAudio[i].volume = volumeFloat;
    }
}