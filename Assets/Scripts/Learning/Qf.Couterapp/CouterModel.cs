using QFramework;
using UnityEngine;

namespace QFramework.Example
{
    public interface ICountModel : IModel
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> bfdb2b3 (学习QF)
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }
<<<<<<< HEAD
        public int LoadInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
=======

        public void LoadInt(string key, int value = 0)
        {
            PlayerPrefs.SetInt(key, (int)value);    
>>>>>>> bfdb2b3 (学习QF)
        }
    }
}