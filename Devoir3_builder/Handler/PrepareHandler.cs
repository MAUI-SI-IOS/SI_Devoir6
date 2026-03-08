using Devoir3_builder.State;
using Devoir3_builder.data;
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


            order.state.Process(order);
            order.Notify("pizza entrain d'etre preparer");
            Console.WriteLine();
            return next is not null ? next.Handle(order) : order;
        }
    }
}
