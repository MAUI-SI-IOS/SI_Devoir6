using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Dispatched : IPizzaState
    {
        private Dispatched() { }
        internal static readonly IPizzaState Instance = new Dispatched();

        public void Process(Pizza pizza)
        {
            pizza.state = Delivered.Instance;
        }
    }
}
