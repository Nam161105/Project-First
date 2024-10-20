using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] protected GameObject flashPrefab;
    protected Queue<GameObject> pool = new Queue<GameObject>();

    private void Start()
    {
 
        for (int i = 0; i < 10; i++)
        {
            GameObject spawnedObject = Instantiate(flashPrefab);
            spawnedObject.SetActive(false); 
            pool.Enqueue(spawnedObject); 
        }
    }


    public GameObject GetFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue(); 
            obj.SetActive(true);
            return obj;
        }
        else
        {
 
            GameObject newObj = Instantiate(flashPrefab);
            return newObj;  
        }
    }

    
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false); 
        pool.Enqueue(obj);  
    }
}
