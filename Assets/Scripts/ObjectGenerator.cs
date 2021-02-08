using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectPool))]
public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] private float _minCooldown;
    [SerializeField] private float _maxCooldown;

    [SerializeField] private int _minObjectsInLine;
    [SerializeField] private int _maxObjectsInLine;
    [SerializeField] private float _timeBetweenGenerateObjectsInLine;

    private float _elapsedTime = 0;

    private ObjectPool _pool;

    private void Start()
    {
        _pool = GetComponent<ObjectPool>();

        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            for (int i = 0; i < Random.Range(_minObjectsInLine, _maxObjectsInLine); i++)
            {
                if (_pool.TryGetObject(out GameObject result))
                {
                    result.transform.position = transform.position;
                    result.SetActive(true);
                }

                yield return new WaitForSeconds(_timeBetweenGenerateObjectsInLine);
            }

            yield return new WaitForSeconds(Random.Range(_minCooldown, _maxCooldown));
        }
    }
}
