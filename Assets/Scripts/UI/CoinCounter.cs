using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _ball.CollectingCoin += OnCollectingCoin;
    }

    private void OnDisable()
    {
        _ball.CollectingCoin -= OnCollectingCoin;
    }

    private void OnCollectingCoin(int numberOfCoins)
    {
        _text.text = numberOfCoins.ToString();
    }
}
