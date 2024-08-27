using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReflectionTest : MonoBehaviour
{
    public class Ciallo
    {
        public void Say()
        {
            Debug.Log("Ciallo");
        }

        public int Good(string str)
        {
            Debug.Log(str);
            return 1;
        }

        public string FieldA;
        public string PropertyA {  get; set; }  
    }
    private void Start()
    {
        
    }
}
