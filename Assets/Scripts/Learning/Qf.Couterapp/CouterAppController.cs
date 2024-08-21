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
        private ICountModel mModel;

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        private void Start()
        {
            mModel = this.GetModel<ICountModel>();
            BtnAdd.onClick.AddListener(() =>
            {
                this.SendCommand<IncreaseCountCommand>();
            });

            BtnSub.onClick.AddListener(() =>
            {
                this.SendCommand<DecraseCountCommand>();
            });

            UpdateView();
<<<<<<< HEAD
            mModel.Count.Register(e =>
=======
            this.RegisterEvent<CountChangeEvent>(e =>
>>>>>>> bfdb2b3 (学习QF)
            {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        public void UpdateView()
        {
            TextCount.text = mModel.Count.ToString();
            Debug.Log("1");
        }
    }
}