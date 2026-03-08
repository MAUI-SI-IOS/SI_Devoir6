using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    public class Dispatched : IOrderState
    {
        private Dispatched() { }
        internal static readonly IOrderState Instance = new Dispatched();

        public void Process(PizzaOrder order)
        {
            order.state = Delivered.Instance;
        }
    }
}
