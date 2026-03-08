using Devoir3_builder.data;
using Devoir3_builder.Data;
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

            Console.WriteLine("Cutting the pizza...");

            order.state.Process(order);

            return next is not null ? next.Handle(order) : order;
        }
    }
}
