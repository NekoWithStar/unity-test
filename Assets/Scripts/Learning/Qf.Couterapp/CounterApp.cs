using QFramework;

namespace QFramework.Example
{
    // 此处实现一个Qframework架构
    // 然后在架构里注册Model
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterSystem(new AchievementSystem());
            this.RegisterUtility(new Storage());
            this.RegisterModel(new CounterModel());
        }
    }
}