
namespace Devoir3_builder.Observer
{
    public class KitchenScreenObserver : INotify
    {
        public void Notify(string message)
        {
          Console.WriteLine("Kitchen screen: "+ message);
        }
    }
}
