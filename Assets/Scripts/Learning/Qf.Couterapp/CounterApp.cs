using QFramework;

namespace QFramework.Example
{
    // �˴�ʵ��һ��Qframework�ܹ�
    // Ȼ���ڼܹ���ע��Model
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
>>>>>>> bfdb2b3 (学习QF)
        }
    }
}