
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Created : IPizzaState
    {
        private Created() { }
        public static readonly Created Instance = new Created();

        public void Process(Pizza pizza)
        {
            pizza.state = Validated.Instance;
        }
    }
}
