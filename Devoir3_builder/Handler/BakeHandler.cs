using Devoir3_builder.data;
using Devoir3_builder.State;
using System.Diagnostics;

namespace Devoir3_builder.Handler
{
    public class BakeHandler : IPizzaHandler
    {
        public IPizzaHandler Next { set => next = value; }
        private IPizzaHandler? next = null;


        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null);
            Debug.Assert(order.state is not null);
            Debug.Assert(order.state is Prepared);
            
            order.state.Process(order);
            order.Notify("Pizza est entrain d'etre cuite");
            Console.WriteLine();


            return next is not null ? next.Handle(order) : order;
        }
    }
}
