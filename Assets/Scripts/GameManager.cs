using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private SoundManager soundManager;
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Goal;
    public GameObject player2Goal;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    private int player1Score;
    private int player2Score;

    public void Player1Scored() {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        soundManager.PlayGoalSound();
        IncreaseBallSpeed();
        ResetPostion();
    }

    public void Player2Scored() {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        soundManager.PlayGoalSound();
        IncreaseBallSpeed();
        ResetPostion();
    }

    private void ResetPostion() {
        ball.GetComponent<Ball>().ResetPostion();
        player1.GetComponent<Players>().ResetPostion();
        player2.GetComponent<Players>().ResetPostion();
    }

    public int GetTotalScore() {
        return player1Score + player2Score;
    }

    public void IncreaseBallSpeed() {
        if (GetTotalScore() % 6 == 0) {
            ball.GetComponent<Ball>().speed += 1f;
        }
    }

}
