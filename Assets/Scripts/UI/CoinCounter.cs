using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private TMP_Text _coinsText;

    private void OnEnable()
    {
        _ball.CollectedCoin += OnCollectedCoin;
    }

    private void OnDisable()
    {
        _ball.CollectedCoin -= OnCollectedCoin;
    }

    private void OnCollectedCoin(int numberOfCoins)
    {
        _coinsText.text = numberOfCoins.ToString();
    }
}
