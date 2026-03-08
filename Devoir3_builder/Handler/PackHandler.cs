using Devoir3_builder.data;
using Devoir3_builder.Data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir3_builder.Handler
{
    internal class PackHandler : IPizzaHandler
    {
        public IPizzaHandler Next { set => next = value; }
        private IPizzaHandler? next = null;

        public PizzaOrder Handle(PizzaOrder order)
        {
            Debug.Assert(order is not null, "Pizza cannot be null");
            Debug.Assert(order.state is not null, "Pizza state cannot be null");
            Debug.Assert(order.state is Cutted, "Pizza must be cutted before we can pack it");

            Console.WriteLine("Packing pizza...");

            order.state.Process(order);

            return next is not null ? next.Handle(order) : order;
        }
    }
}
