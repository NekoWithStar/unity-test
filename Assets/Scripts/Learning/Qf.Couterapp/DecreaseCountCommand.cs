namespace QFramework.Example
{
    public class DecraseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterModel>().Count.Value--;
        }
    }
}