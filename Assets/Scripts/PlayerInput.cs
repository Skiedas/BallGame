using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BallJump))]
public class PlayerInput : MonoBehaviour
{
    private BallJump _ballJump;

    void Start()
    {
        _ballJump = GetComponent<BallJump>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_ballJump.JumpsLeft > 0)
            {
                _ballJump.Jump();
            }
        }
    }
}
