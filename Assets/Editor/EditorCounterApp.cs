using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace QFramework.Example
{
    public class EditorCounterApp : EditorWindow, IController
    {
        [MenuItem("CounterApp/Window")]
        public static void Open()
        {
            var counterApp = GetWindow<EditorCounterApp>();
            counterApp.Show();
        }

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        private ICountModel mModel;
        private void OnEnable()
        {
            mModel = this.GetModel<ICountModel>();
        }

        private void OnDisable()
        {
            mModel = null;  
        }

        private void OnGUI()
        {
            if(GUILayout.Button("+"))
            {
                this.SendCommand<IncreaseCountCommand>();
            }
            GUILayout.Label(mModel.Count.Value.ToString());
            if (GUILayout.Button("-"))
            {
                this.SendCommand<DecraseCountCommand>();
            }
        }
    }
}
