using Devoir3_builder.data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    public class PrepareHandler : IPizzaHandler
    {
        public void Handle(Pizza pizza)
        {
            Debug.Assert(pizza is not null);
            Debug.Assert(pizza.state is not null);
            Debug.Assert(pizza.state is Validated);

            //TODO: implementer la logique de préparation de la pizza

            pizza.state.Process(pizza);
        }
    }
}
