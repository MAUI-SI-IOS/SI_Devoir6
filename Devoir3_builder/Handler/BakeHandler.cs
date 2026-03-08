
using Devoir3_builder.data;
using Devoir3_builder.Data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class BakeHandler : IPizzaHandler
    {
        public IPizzaHandler Next { set => next = null; }
        private IPizzaHandler? next = null;

        public void Handle(Pizza pizza)
        {
            
        }

        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null);
            Debug.Assert(order.state is not null);
            Debug.Assert(order.state is Prepared);

            Console.WriteLine("Cuisson de la pizza...");

            order.state.Process(order);

            return next is not null ? next.Handle(order) : order;
        }
    }
}
