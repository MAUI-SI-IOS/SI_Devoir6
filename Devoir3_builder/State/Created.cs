
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Created : IOrderState
    {
        private Created() { }
        public static readonly Created Instance = new Created();

        public void Process(PizzaOrder order)
        {
            order.state = Validated.Instance;
        }
    }
}
