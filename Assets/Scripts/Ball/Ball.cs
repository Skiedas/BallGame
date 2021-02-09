using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public event UnityAction<int> CollectedCoin;

    private int _coins;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void CollectCoin()
    {
        _coins++;
        CollectedCoin?.Invoke(_coins);
    }

    public void ResetBall()
    {
        transform.position = _startPosition;
        _coins = 0;
        CollectedCoin?.Invoke(_coins);
    }
}
