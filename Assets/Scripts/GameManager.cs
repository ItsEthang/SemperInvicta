using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverSfx;
    [SerializeField] private AudioClip victorySfx;

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
}