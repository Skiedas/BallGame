using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private int _jumpsCount;

    public int JumpsLeft => _jumpsLeft;

    private Rigidbody2D _rb;
    private int _jumpsLeft;
    private bool _isGrounded;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _jumpsLeft = _jumpsCount;
    }

    private void Update()
    {
        if (_isGrounded && _jumpsLeft < _jumpsCount)
        {
            _jumpsLeft++;
        }
    }

    public void SetGrounded(bool state)
    {
        _isGrounded = state;
    }

    public void Jump()
    {
        _jumpsLeft--;
        SetGrounded(false);
        _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
