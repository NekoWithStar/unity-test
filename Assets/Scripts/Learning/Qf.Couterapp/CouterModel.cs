using QFramework;
using UnityEngine;

namespace QFramework.Example
{
    public interface ICountModel : IModel
    {
        BindableProperty<int> Count {  get; }
    }
    public class CounterModel : AbstractModel, ICountModel
    {
        public BindableProperty<int> Count { get; } = new BindableProperty<int>(0);
        protected override void OnInit()
        {
            var mStorage = this.GetUtility<IStorage>();
            mStorage.LoadInt(nameof(Count.Value));
            Count.Register(e =>
            {
                mStorage.SaveInt(nameof(Count.Value), Count.Value);    
            });
        }
    }

    public interface IStorage : IUtility
    {
        void SaveInt(string key, int value);
        int LoadInt(string key, int defaultValue = 0);
    }

    public class Storage : IStorage
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }
        public int LoadInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }
    }
}