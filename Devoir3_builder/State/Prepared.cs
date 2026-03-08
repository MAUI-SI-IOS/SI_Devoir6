using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Prepared : IOrderState
    {
        private Prepared() { }
        internal static readonly IOrderState Instance = new Prepared();

        public void Process(PizzaOrder order)
        {
            order.state = Baked.Instance;
        }
    }
}
