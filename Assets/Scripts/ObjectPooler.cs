using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {
    public GameObject pooledObject;
    public int pooledAmount;
    private List<GameObject> pooledObjects;

    public GameObject GetPooledObject() {
        for (int i = 0; i < pooledObjects.Count; i++)
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];

        GameObject obj = Instantiate(pooledObject);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;
    }

    // Start is called before the first frame update
    private void Start() {
        pooledObjects = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++) {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
}