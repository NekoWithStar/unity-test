using QFramework;

namespace QFramework.Example
{
    // 此处实现一个Qframework架构
    // 然后在架构里注册Model
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
<<<<<<< HEAD
            this.RegisterSystem<IAchievementSystem>(new AchievementSystem());
            this.RegisterUtility<IStorage>(new Storage());
            this.RegisterModel<ICountModel>(new CounterModel());
=======
            this.RegisterUtility(new Storage());
            this.RegisterModel(new CounterModel());
>>>>>>> bfdb2b3 (瀛︿範QF)
        }
    }
}