using Devoir3_builder.Data;
using System.Diagnostics;

namespace Devoir3_builder.State
{
    public class Delivered : IOrderState
    {
        private Delivered() { }
        internal static readonly IOrderState Instance = new Delivered();

        public void Process(PizzaOrder order)
        {
            Debug.WriteLine("Pizza has been delivered to the customer. Enjoy your meal! No need to process it further");
        }
    }
}
