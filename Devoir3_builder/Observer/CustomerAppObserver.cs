namespace Devoir3_builder.Observer
{
    public class CustomerAppObserver : INotify
    {
        public void Notify(string message)
        {
           Console.WriteLine("Customer app: "+ message); 
        }
    }
}
