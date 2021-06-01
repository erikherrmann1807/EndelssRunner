using UnityEngine;

public class PowerUps : MonoBehaviour {
    public bool doublePoints;
    public bool safeMode;

    public float powerupLength;

    private PowerupManager thePowerupManager;

    // Start is called before the first frame update
    private void Start() {
        thePowerupManager = FindObjectOfType<PowerupManager>();
    }

    // Update is called once per frame
    private void Update() { }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.name == "Player") thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLength);
        gameObject.SetActive(false);
    }
}