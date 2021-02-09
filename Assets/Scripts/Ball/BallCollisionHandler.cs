using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BallJump))]
[RequireComponent(typeof(Ball))]
public class BallCollisionHandler : MonoBehaviour
{
    [SerializeField] private GameOverPanel _gameOverPanel;

    private Ball _ball;
    private BallJump _ballJump;

    private void Start()
    {
        _ball = GetComponent<Ball>();
        _ballJump = GetComponent<BallJump>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.TryGetComponent(out Barrier barrier))
        //{
        //    _gameOverPanel.SetActive(true);
        //}

        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _ballJump.SetGrounded(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.TryGetComponent(out Coin coin))
        {
            coin.gameObject.SetActive(false);
            _ball.CollectCoin();
        }

        if (collider.TryGetComponent(out Barrier barrier))
        {
            _gameOverPanel.SetActive(true);
        }
    }
}
