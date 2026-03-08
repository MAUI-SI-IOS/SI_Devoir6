using Devoir3_builder.data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class ValidateOrderHandler : IPizzaHandler
    {
        public IPizzaHandler Next { set { next = value; } }
        private IPizzaHandler? next = null;


        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null);
            Debug.Assert(order.state is not null);
            Debug.Assert(order.state is Created, "Pizza should be created when validationg the order");


            order.state.Process(order);
            order.Notify("validating pizza order");
            
            return next is not null ? next.Handle(order) : order;
        }
    }
}
