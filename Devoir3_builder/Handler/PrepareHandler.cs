using Devoir3_builder.Data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class PrepareHandler : IPizzaHandler
    {
        public IPizzaHandler Next { set { next = value; }  }
        private IPizzaHandler? next = null;

        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null);
            Debug.Assert(order.state is not null);
            Debug.Assert(order.state is Validated);

            //TODO: implementer la logique de préparation de la pizza

            order.state.Process(order);

            return next is not null ? next.Handle(order) : order;
        }
    }
}
