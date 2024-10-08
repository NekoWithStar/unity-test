using QFramework;

namespace QFramework.Example
{
    // 此处实现一个Qframework架构
    // 然后在架构里注册Model
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterSystem<IAchievementSystem>(new AchievementSystem());
            this.RegisterUtility<IStorage>(new Storage());
            this.RegisterModel<ICountModel>(new CounterModel());
        }
    }
}