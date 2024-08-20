using UnityEngine;
namespace QFramework.Example
{
    public interface IAchievementSystem : ISystem
    {
        
    }


    public class AchievementSystem : AbstractSystem, IAchievementSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<ICountModel>();
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
