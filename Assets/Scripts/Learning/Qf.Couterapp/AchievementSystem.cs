using UnityEngine;
namespace QFramework.Example
{
    public class AchievementSystem : AbstractSystem
    {
        protected override void OnInit()
        {
            var modle = this.GetModel<CounterModel>();
            this.RegisterEvent<CountChangeEvent>(
                e =>
                {
                    if (modle.Count == 10)
                    {
                        Debug.Log("点击达人成就");
                    }
                    else if (modle.Count == 20)
                    {
                        Debug.Log("点击大神成就");
                    }
                    else if (modle.Count == -10)
                    {
                        Debug.Log("点击菜鸟");
                    }
                });
        }
    }
}
