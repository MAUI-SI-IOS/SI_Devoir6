using Devoir3_builder.data;
using Devoir3_builder.Data;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

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

            // TODO: implement validation logic for the pizza order

            order.state.Process(order);

            return next is not null ? next.Handle(order) : order;
        }
    }
}
