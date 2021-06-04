﻿using UnityEngine;

public class pickUpPoints : MonoBehaviour {
    public int scoreToGive;

    private ScoreManager theScoreManager;

    private AudioSource coinSound;

    private PowerUps myPowerUps;

    // Start is called before the first frame update
    private void Start() {
        theScoreManager = FindObjectOfType<ScoreManager>();
        myPowerUps = FindObjectOfType<PowerUps>();
        
        scoreToGive *= myPowerUps.multiplier;

        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update() { }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player") {
            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);

            if (coinSound.isPlaying) {
                coinSound.Stop();
                coinSound.Play();
            }
            else {
                coinSound.Play();
            }
        }
    }
}