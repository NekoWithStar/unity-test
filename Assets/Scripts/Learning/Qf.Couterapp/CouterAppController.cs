using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace QFramework.Example
{
    //Controller
    public class CouterAppController : MonoBehaviour, IController
    {
        //View
        public Button BtnAdd;
        public Button BtnSub;
        public TextMeshProUGUI TextCount;
        private CounterModel mModel;

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        private void Start()
        {
            mModel = this.GetModel<CounterModel>();
            BtnAdd.onClick.AddListener(() =>
            {
               this.SendCommand<IncreaseCountCommand>();
                // 表现逻辑
                UpdateView();
            });

            BtnSub.onClick.AddListener(() =>
            {
                this.SendCommand<DecraseCountCommand>();
                // 表现逻辑
                UpdateView();
            });

            UpdateView();
            mModel.Count.Register(e =>
            {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void UpdateView()
        {
            TextCount.text = mModel.Count.ToString();
        }
    }
}