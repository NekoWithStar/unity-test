using UnityEngine;
namespace QFramework.Example
{
    public class AchievementSystem : AbstractSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<CounterModel>();
            model.Count.Register(
                e =>
                {
                    if (model.Count.Value == 10)
                    {
                        Debug.Log("点击达人成就");
                    }
                    else if (model.Count.Value == 20)
                    {
                        Debug.Log("点击大神成就");
                    }
                    else if (model.Count.Value == -10)
                    {
                        Debug.Log("点击菜鸟");
                    }
                });
        }
    }
}
