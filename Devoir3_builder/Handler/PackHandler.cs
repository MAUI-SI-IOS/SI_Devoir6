using Devoir3_builder.data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    internal class PackHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null, "Pizza cannot be null");
            Debug.Assert(pizza.state is not null, "Pizza state cannot be null");
            Debug.Assert(pizza.state is Cutted, "Pizza must be cutted before we can pack it");

            Console.WriteLine("Packing pizza...");

            pizza.state.Process(pizza);
        }
    }
}
