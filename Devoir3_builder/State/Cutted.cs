
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    internal class Cutted : IPizzaState
    {
        private Cutted() { }
        public readonly static IPizzaState Instance = new Cutted();

        public void Process(Pizza pizza)
        {
            pizza.state = Packed.Instance;
        }
    }
}
