using QFramework;

namespace QFramework.Example
{
    // �˴�ʵ��һ��Qframework�ܹ�
    // Ȼ���ڼܹ���ע��Model
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterUtility(new Storage());
            this.RegisterModel(new CounterModel());
        }
    }
}