using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{

    [SerializeField] protected GameObject explosionPrefab;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.playerClip);
        }

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
