
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Baked : IPizzaState
    {
        private Baked() { }
        internal static readonly IPizzaState Instance = new Baked();

        public void Process(Pizza pizza)
        {
            pizza.state = Cutted.Instance;
        }
    }
}
