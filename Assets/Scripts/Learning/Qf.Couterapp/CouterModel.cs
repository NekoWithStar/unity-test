using QFramework;

namespace QFramework.Example
{
    public class CounterModel : AbstractModel
    {
        public int Count = 0;
        protected override void OnInit()
        {
            Count = 0;
        }
    }
}