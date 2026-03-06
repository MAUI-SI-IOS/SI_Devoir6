using Devoir3_builder.data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    public class DispatchHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null);
            Debug.Assert(pizza.state is not null);
            Debug.Assert(pizza.state is Packed, "Pizza must be packed before we can dispatch it for delivery");

            Console.WriteLine($"Dispatching pizza for delivery: {pizza}");

            pizza.state.Process(pizza);
        }
    }
}
