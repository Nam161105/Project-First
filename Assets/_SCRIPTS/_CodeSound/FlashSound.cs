using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashSound : MonoBehaviour
{
    public AudioManager audioManager1;

    private void Awake()
    {
        audioManager1 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            audioManager1.PlaySFX(audioManager1.flashClip);
        }
    }
}
