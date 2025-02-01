using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ref : Last comp sci class
public class ObjectPool : MonoBehaviour
{

    private List<GameObject> pool = new List<GameObject>();

    [SerializeField] GameObject[] ObjectsToPool;
    [SerializeField] float[] quantityPerObjet;

    public static ObjectPool ObjectPoolInstance;

    private void Awake()
    {
        if (ObjectPoolInstance == null)
            ObjectPoolInstance = this;
    }

    void Start()
    {
        for (int i = 0; i < Mathf.Min(ObjectsToPool.Length, quantityPerObjet.Length); i++)
        {
            for (int o = 0; o < quantityPerObjet[i]; o++)
            {
                GameObject obj = Instantiate(ObjectsToPool[i]);
                obj.name = ObjectsToPool[i].name;
                obj.SetActive(false);
                pool.Add(obj);
            }
        }
    }


    public GameObject GetPooledObject(GameObject typeObjet)
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy && pool[i].name == typeObjet.name)
            {
                return pool[i];
            }
        }
        return null;
    }
}
