using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderer : MonoBehaviour
{
    public Transform ��������;
    public float ��ת�ٶ�;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(��������.transform.position, Vector3.up, ��ת�ٶ� * Time.deltaTime);
    }
}
