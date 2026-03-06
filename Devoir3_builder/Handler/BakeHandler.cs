
using Devoir3_builder.data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class BakeHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null);
            Debug.Assert(pizza.state is not null);
            Debug.Assert(pizza.state is Prepared);

            Console.WriteLine("Cuisson de la pizza...");

            pizza.state.Process(pizza);
        }
    }
}
