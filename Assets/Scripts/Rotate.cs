using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float yAngle = 180.0f;
    public float rotateSpeed = 1.0f;

    void Update()
    {
        transform.Rotate(Vector3.up, yAngle * rotateSpeed * Time.deltaTime);
    }
}
