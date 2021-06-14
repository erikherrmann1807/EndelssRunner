using UnityEngine;
using UnityEngine.UI;

public class CoinPickUp : MonoBehaviour {
    public static CoinPickUp instance;
    public int scoreToGive;
    private int coin;

    public Text _coinText;
    private ScoreManager _theScoreManager;

    private AudioSource _coinSound;

    private PowerUps _myPowerUps;

    // Start is called before the first frame update
    private void Start() {

        if (instance == null) {
            instance = this;
        }
        
        _theScoreManager = FindObjectOfType<ScoreManager>();
        _myPowerUps = FindObjectOfType<PowerUps>();
        _coinText = GameObject.Find("CoinText").GetComponent<Text>();
        
        //scoreToGive *= _myPowerUps.multiplier;

        _coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update() {
        //_coinText.text = "Coins: " + coins;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player") {
            _theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);

            if (_coinSound.isPlaying) {
                _coinSound.Stop();
                _coinSound.Play();
            }
            else {
                _coinSound.Play();
            }
        }
    }

    public void CoinCounter(int coinValue) {
        coin += coinValue;
        _coinText.text = "Coins: " + coin;
        Debug.Log("Hochgezählt!");
    }
}