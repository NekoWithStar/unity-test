namespace QFramework.Example
{
    public class DecraseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
<<<<<<< HEAD
            this.GetModel<ICountModel>().Count.Value--;
=======
            this.GetModel<CounterModel>().Count--;
            this.SendEvent<CountChangeEvent>();
>>>>>>> bfdb2b3 (学习QF)
        }
    }
}