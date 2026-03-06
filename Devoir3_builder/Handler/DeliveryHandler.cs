
using Devoir3_builder.data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class DeliveryHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null);
            Debug.Assert(pizza.state is not null);
            Debug.Assert(pizza.state is Dispatched);

            Console.WriteLine("Pizza is being delivered...");

            pizza.state.Process(pizza);
        }
    }
}
