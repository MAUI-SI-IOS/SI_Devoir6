
using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    public class Baked : IOrderState
    {
        private Baked() { }
        internal static readonly IOrderState Instance = new Baked();

        public void Process(PizzaOrder order)
        {
            order.state = Cutted.Instance;
        }
    }
}
