using QFramework;
using UnityEngine;

namespace QFramework.Example
{
    public class CounterModel : AbstractModel
    {
        public BindableProperty<int> Count = new BindableProperty<int>(0);
        protected override void OnInit()
        {
            var mStorage = this.GetUtility<Storage>();
            mStorage.LoadInt(nameof(Count.Value));
            Count.Register(e =>
            {
                mStorage.SaveInt(nameof(Count.Value), Count.Value);    
            });
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