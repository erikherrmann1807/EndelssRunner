using System;
using System.Security.Cryptography;
using UnityEngine;

public class JumpParticle : MonoBehaviour {
    [SerializeField] private GameObject jumpParticle;
    public float lifeTime = 0.25f;

    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Ground")) {
            Instantiate(jumpParticle, transform.position, jumpParticle.transform.rotation);
            Destroy(jumpParticle, lifeTime);
        }
    }
}