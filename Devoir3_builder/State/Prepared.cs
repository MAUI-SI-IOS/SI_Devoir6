
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Prepared : IPizzaState
    {
        private Prepared() { }
        internal static readonly IPizzaState Instance = new Prepared();

        public void Process(Pizza pizza)
        {
            pizza.state = Baked.Instance;
        }
    }
}
