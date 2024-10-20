using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] protected AudioManager _audioManager;

    [SerializeField] protected GameObject explosionPrefab;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            _audioManager.PlaySFX(_audioManager.playerClip);
        }

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
