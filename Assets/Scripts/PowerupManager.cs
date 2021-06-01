using UnityEngine;

public class PowerupManager : MonoBehaviour {
    private bool doublePoints;
    private bool safeMode;

    private bool powerupActive;

    private float powerupLengthCounter;

    private ScoreManager theScoreManager;
    private PlatformGenerator thePLatformGenerator;

    private float normalPointsPerSecond;
    private float spikeRate;

    public void ActivatePowerup(bool points, bool safe, float time) {
        doublePoints = points;
        safeMode = safe;
        powerupLengthCounter = time;

        normalPointsPerSecond = theScoreManager.pointsPerSecond;
        spikeRate = thePLatformGenerator.randomSpikeThreshold;

        powerupActive = true;
    }

    // Start is called before the first frame update
    private void Start() {
        theScoreManager = FindObjectOfType<ScoreManager>();
        thePLatformGenerator = FindObjectOfType<PlatformGenerator>();
    }

    // Update is called once per frame
    private void Update() {
        if (powerupActive) {
            powerupLengthCounter -= Time.deltaTime;

            if (doublePoints) {
                theScoreManager.pointsPerSecond = normalPointsPerSecond * 2;
                theScoreManager.shouldDouble = true;
            }

            if (safeMode) thePLatformGenerator.randomSpikeThreshold = 0;

            if (powerupLengthCounter <= 0) {
                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theScoreManager.shouldDouble = false;

                thePLatformGenerator.randomSpikeThreshold = spikeRate;
                powerupActive = false;
            }
        }
    }
}