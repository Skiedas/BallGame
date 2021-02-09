using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _offsetX;

    private void Update()
    {
        transform.position = new Vector3(_ball.transform.position.x + _offsetX, transform.position.y, transform.position.z);
    }
}
