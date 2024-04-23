using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour {
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private Vector3 startPosition;
    private float movement;
    
    private void Start() {
        startPosition = transform.position;
    }

    private void Update() {
        if (isPlayer1) {
            movement = Input.GetAxisRaw("Vertical");
        } else {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void ResetPostion() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}
