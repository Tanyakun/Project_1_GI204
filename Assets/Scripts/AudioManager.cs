using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------ Audio Source ------------")]
    [SerializeField] AudioSource musicSource;

    [Header("------------ Audio Clip ------------")]
    [SerializeField] AudioClip musicClip;

    private void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }
}
