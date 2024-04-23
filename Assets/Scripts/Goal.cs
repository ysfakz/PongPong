using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour {
    [SerializeField] private GameManager gameManager;
    public bool isPlayer1Goal;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            if (isPlayer1Goal) {
                gameManager.Player2Scored();
            } else {
                gameManager.Player1Scored();
            }
        }
    }

}
