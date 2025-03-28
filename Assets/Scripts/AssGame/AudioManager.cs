using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------ Audio Source ------------")]
    [SerializeField] AudioSource musicSource;

    [Header("------------ Audio Clip ------------")]
    [SerializeField] AudioClip musicClip;

    private void Start()
    {
        if (musicSource != null && musicClip != null && musicSource.enabled)
        {
            musicSource.clip = musicClip;
            musicSource.Play();
        }
        else
        {
            Debug.LogError("Audio Source or Audio Clip is not assigned or Audio Source is disabled!");
        }
    }
}