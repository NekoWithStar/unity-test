namespace QFramework.Example
{
    public class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterModel>().Count.Value++;
        }
    }
}