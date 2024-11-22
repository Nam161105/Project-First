using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    protected static AudioManager instance;
    public static AudioManager Instance {  get { return instance; } }

    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip flashClip;
    public AudioClip exploreClip;
    public AudioClip gameoverClip;
    public AudioClip winClip;
    public AudioClip playerClip;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();    
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }
}
