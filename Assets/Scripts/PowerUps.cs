using UnityEngine;

public class PowerUps : MonoBehaviour {

    public int multiplier;
    private void Start() {
        DontDestroyOnLoad(gameObject);
        multiplier = 1;
    }

    public void CoinMultiplier() {
        Debug.Log("Multiplier erhöht");
        multiplier += 1;
    }
}