using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {
    public GameObject platformDestructionPoint;

    // Start is called before the first frame update
    private void Start() {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    // Update is called once per frame
    private void Update() {
        if (transform.position.x < platformDestructionPoint.transform.position.x)
            //Destroy (gameObject);

            gameObject.SetActive(false);
    }
}