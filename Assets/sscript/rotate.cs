using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float y = 180;
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, y++, 0);
    }
}
