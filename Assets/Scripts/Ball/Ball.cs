using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public event UnityAction<int> CollectingCoin;

    private int _numberOfCoins;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void CollectCoin()
    {
        _numberOfCoins++;
        CollectingCoin?.Invoke(_numberOfCoins);
    }

    public void ResetBall()
    {
        transform.position = _startPosition;
        _numberOfCoins = 0;
        CollectingCoin?.Invoke(_numberOfCoins);
    }
}
