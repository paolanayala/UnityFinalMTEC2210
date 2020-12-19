using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public static PlaySound Instance = null;

    public AudioClip fastinvader1;
    public AudioClip fastinvader2;
    public AudioClip invaderkilled;
    public AudioClip shoot;
    public AudioClip explosion;

    private AudioSource soundEffectAudio;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
        soundEffectAudio = audioSource;

    }

   public void PlayOneShot(AudioClip clip)
    {
        soundEffectAudio.PlayOneShot(clip);
    }

}