using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BompSound : MonoBehaviour
{
    [SerializeField] protected AudioManager AudioManager;
    [SerializeField] protected GameObject explisionPrefab1;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(gameObject); 
            AudioManager.PlaySFX(AudioManager.exploreClip);
            Instantiate(explisionPrefab1, transform.position, Quaternion.identity);
        }
    }

}
