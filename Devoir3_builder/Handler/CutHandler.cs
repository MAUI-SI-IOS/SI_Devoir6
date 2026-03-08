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
        public IPizzaHandler Next { set => next = value; }
        private IPizzaHandler? next = null;

        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null, "Pizza should not be null");
            Debug.Assert(order.state is not null, "Pizza state should not be null");
            Debug.Assert(order.state is Baked, "Pizza should be baked before it is cutted");
            order.state.Process(order);
            order.Notify("pizza est entrain d'etre couper");
            Console.WriteLine();



            return next is not null ? next.Handle(order) : order;
        }
    }
}
