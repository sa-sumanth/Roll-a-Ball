using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;

    void Start()
    {
        offset = gameObject.transform.position - ball.transform.position;
    }

    void LateUpdate()
    {
        gameObject.transform.position = ball.transform.position + offset;
    }
}
