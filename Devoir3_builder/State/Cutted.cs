
using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    internal class Cutted : IOrderState
    {
        private Cutted() { }
        public readonly static IOrderState Instance = new Cutted();

        public void Process(PizzaOrder order)
        {
            order.state = Packed.Instance;
        }
    }
}
