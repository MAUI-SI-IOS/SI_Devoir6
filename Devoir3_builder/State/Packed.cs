using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    public class Packed : IOrderState
    {
        private Packed() { }
        internal static readonly IOrderState Instance = new Packed();

        public void Process(PizzaOrder order)
        {
            order.state = Dispatched.Instance;
        }
    }
}
