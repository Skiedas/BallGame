using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] GameObject _template;
    [SerializeField] private int _capacity;

    private List<GameObject> _pool = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < _capacity; i++)
        {
            SpawnObject();
        }
    }

    public bool TryGetObject(out GameObject result)
    {
        result = null;

        foreach (var item in _pool)
        {
            if(item.activeSelf == false)
            {
                result = item;
            }
        }

        return result != null;
    }

    private void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(_template, _container);
        _pool.Add(spawnedObject);
        spawnedObject.SetActive(false);
    }

    public void ResetObjects()
    {
        foreach (var item in _pool)
        {
            item.SetActive(false);
        }
    }
}
