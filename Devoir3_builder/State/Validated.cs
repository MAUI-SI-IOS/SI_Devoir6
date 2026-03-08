
using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    public class Validated : IOrderState
    {
        private Validated() { }
        public static readonly Validated Instance = new Validated();

        public void Process(Pizza pizza)
        {
            pizza.state = Prepared.Instance;
        }

        public void Process(PizzaOrder order)
        {
            order.state = Prepared.Instance;
        }
    }
}
