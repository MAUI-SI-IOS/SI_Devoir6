using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class Director
    {
        IPizzaBuilder builder;

        public Director(IPizzaBuilder builder)
        {
            this.builder = builder;
        }

        public Pizza make()
        {
            return builder.makeDough()
                          .makeSauce()
                          .makeToppings()
                          .makePrix()
                          .make();
        }
    }
}
