using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Validated : IOrderState
    {
        private Validated() { }
        public static readonly Validated Instance = new Validated();

        public void Process(PizzaOrder order)
        {
            order.state = Prepared.Instance;
        }

    }
}
