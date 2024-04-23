using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    [SerializeField] private AudioSource soundManager;
    [SerializeField] private AudioClip playerCollisionSound;
    [SerializeField] private AudioClip wallCollisionSound;
    [SerializeField] private AudioClip goalSound;

    public void PlayPlayerCollisionSound() {
        soundManager.PlayOneShot(playerCollisionSound);
    }

    public void PlayWallCollisionSound() {
        soundManager.PlayOneShot(wallCollisionSound);
    }

    public void PlayGoalSound() {
        soundManager.PlayOneShot(goalSound);
    }

}
