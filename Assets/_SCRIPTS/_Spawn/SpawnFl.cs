using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFl : MonoBehaviour
{
    protected PoolManager poolManager;
    [SerializeField] protected float spawnDistance;
    [SerializeField] protected float flashLifeTime;
    private void Start()
    {
        poolManager = FindObjectOfType<PoolManager>();
        if (poolManager == null)
        {
            Debug.LogError("Không tìm thấy PoolManager trong scene.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Flash"))
        {
            Vector2 spawnPosition = transform.position + transform.up * spawnDistance;
            spawnPosition += new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            GameObject flash = poolManager.GetFromPool();
            flash.transform.position = spawnPosition;
            flash.transform.rotation = Quaternion.identity;
            StartCoroutine(FlashLifeCycle(flash));
        }
    }
    private IEnumerator FlashLifeCycle(GameObject flash)
    {
        yield return new WaitForSeconds(flashLifeTime);
        poolManager.ReturnToPool(flash);
    }
    
}