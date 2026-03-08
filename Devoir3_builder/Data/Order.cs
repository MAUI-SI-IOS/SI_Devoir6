using Devoir3_builder.builder;
using Devoir3_builder.Observer;
using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.Data
{
    public class PizzaOrder
    {
        public IPizzaBuilder Builder;
        public IOrderState state;

        private List<INotify> observers = [];



    }
}
