using Devoir3_builder.data;
using System.Diagnostics;

namespace Devoir3_builder.State
{
    public class Delivered : IPizzaState
    {
        private Delivered() { }
        internal static readonly IPizzaState Instance = new Delivered();

        public void Process(Pizza pizza)
        {
            Debug.WriteLine("Pizza has been delivered to the customer. Enjoy your meal! No need to process it further");
        }
    }
}
