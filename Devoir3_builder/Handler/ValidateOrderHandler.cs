using Devoir3_builder.data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    public class ValidateOrderHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null);
            Debug.Assert(pizza.state is not null);
            Debug.Assert(pizza.state is Created, "Pizza should be created when validationg the order");

            // TODO: implement validation logic for the pizza order

            pizza.state.Process(pizza);
        }
    }
}
