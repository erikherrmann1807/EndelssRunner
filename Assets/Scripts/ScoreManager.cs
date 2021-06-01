using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    public bool shouldDouble;

    public void AddScore(int pointsToAdd) {
        if (shouldDouble) pointsToAdd = pointsToAdd * 2;
        scoreCount += pointsToAdd;
    }

    // Start is called before the first frame update
    private void Start() {
        if (PlayerPrefs.HasKey("HighScore")) hiScoreCount = PlayerPrefs.GetFloat("HighScore");
    }

    // Update is called once per frame
    private void Update() {
        if (scoreIncreasing) scoreCount += pointsPerSecond * Time.deltaTime;

        if (scoreCount > hiScoreCount) {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
    }
}