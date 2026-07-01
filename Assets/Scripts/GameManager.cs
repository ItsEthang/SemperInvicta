using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverSfx;
    [SerializeField] private AudioClip victorySfx;
    [SerializeField] private AudioClip pickUpSfx;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSfx);
    }

    public void PlayVictorySound()
    {
        audioSource.PlayOneShot(victorySfx);
    }

    public void PlayPickUpSound()
    {
        audioSource.PlayOneShot(pickUpSfx);
    }
}