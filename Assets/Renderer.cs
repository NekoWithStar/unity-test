using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderer : MonoBehaviour
{
    public Transform 绕行物体;
    public float 旋转速度;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(绕行物体.transform.position, Vector3.up, 旋转速度 * Time.deltaTime);
    }
}
