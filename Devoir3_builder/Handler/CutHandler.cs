using Devoir3_builder.data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    public class CutHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null, "Pizza should not be null");
            Debug.Assert(pizza.state is not null, "Pizza state should not be null");
            Debug.Assert(pizza.state is Baked, "Pizza should be baked before it is cutted");

            Console.WriteLine("Cutting the pizza...");

            pizza.state.Process(pizza);
        }
    }
}
