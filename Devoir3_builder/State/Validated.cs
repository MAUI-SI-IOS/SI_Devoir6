
using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public class Validated : IPizzaState
    {
        private Validated() { }
        public static readonly Validated Instance = new Validated();

        public void Process(Pizza pizza)
        {
            pizza.state = Prepared.Instance;
        }
    }
}
