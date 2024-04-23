using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] private SoundManager soundManager;
    public float speed;
    public Rigidbody2D rb;
    private Vector3 startPosition;

    public void Start() {
        startPosition =  transform.position;
        LaunchBall();
    }

    public void LaunchBall() {
       float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y); 
    }

    public void ResetPostion() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        LaunchBall();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            soundManager.PlayPlayerCollisionSound();
        }
        if (collision.gameObject.CompareTag("Wall")) {
            soundManager.PlayWallCollisionSound();
        }
    }

}
