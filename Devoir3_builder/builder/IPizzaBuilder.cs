using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public interface IPizzaBuilder
    {
        public IPizzaBuilder setSize(Pizza.Grandeur grandeur);
        public IPizzaBuilder makeDough();
        public IPizzaBuilder makeSauce();
        public IPizzaBuilder makeToppings();
        public IPizzaBuilder makePrix();
        public Pizza make();
    }
}
