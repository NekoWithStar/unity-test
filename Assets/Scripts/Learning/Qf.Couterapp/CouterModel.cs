using QFramework;
using UnityEngine;

namespace QFramework.Example
{
    public class CounterModel : AbstractModel
    {
        private int mCount;
        private Storage mStorage;
        public int Count
        {
            get => mCount;
            set
            {
                if (mCount != value)
                {
                    mCount = value;
                    mStorage?.SaveInt(nameof(Count), value);
                }
            }
        }
        protected override void OnInit()
        {
            mStorage = this.GetUtility<Storage>();
            mStorage.LoadInt(nameof(Count));
        }
    }

    public class Storage : IUtility
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public void LoadInt(string key, int value = 0)
        {
            PlayerPrefs.SetInt(key, (int)value);    
        }
    }
}