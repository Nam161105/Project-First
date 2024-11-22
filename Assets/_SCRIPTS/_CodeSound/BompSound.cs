using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BompSound : MonoBehaviour
{
    [SerializeField] protected GameObject explisionPrefab1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(gameObject);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.exploreClip);
            Instantiate(explisionPrefab1, transform.position, Quaternion.identity);
        }
    }

}
