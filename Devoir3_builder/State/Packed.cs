using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Packed : IPizzaState
    {
        private Packed() { }
        internal static readonly IPizzaState Instance = new Packed();

        public void Process(Pizza pizza)
        {
            pizza.state = Dispatched.Instance;
        }
    }
}
