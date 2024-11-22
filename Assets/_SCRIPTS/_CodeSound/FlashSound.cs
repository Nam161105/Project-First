using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashSound : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.flashClip);
        }
    }
}
