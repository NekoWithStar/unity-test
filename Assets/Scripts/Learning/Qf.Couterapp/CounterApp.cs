using QFramework;

namespace QFramework.Example
{
    // �˴�ʵ��һ��Qframework�ܹ�
    // Ȼ���ڼܹ���ע��Model
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