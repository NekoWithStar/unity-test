using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFramework.Example
{

    public interface IEventA
    {

    }
    public struct EventA : IEventA
    {
        public int Count;
    }

    public class TypeEventSystemExample : MonoBehaviour
    {
        private void Start()
        {
            TypeEventSystem.Global.Register<IEventA>(e => {
                if(e is EventA)
                {
                    Debug.Log("event is received");
                }
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TypeEventSystem.Global.Send<IEventA>(new EventA()
                {
                    Count = 0
                });
            }
        }
    }
}
