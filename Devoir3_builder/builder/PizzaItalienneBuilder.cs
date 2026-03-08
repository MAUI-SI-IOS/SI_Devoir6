using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaItalienneBuilder : IPizzaBuilder
    {
        Pizza pizza;

        public PizzaItalienneBuilder()
        {
            this.pizza = new Pizza();
        }
        public IPizzaBuilder makeDough()
        {
            this.pizza.setPate("pate italien");
            return this;
        }

        public IPizzaBuilder makeSauce()
        {
            this.pizza.setSauce("sauce italien");
            return this;
        }

        public IPizzaBuilder makeToppings()
        {
            this.pizza.setGarniture("garnitures italien");
            return this;
        }
        public Pizza make()
        {
            return this.pizza;
        }

        public IPizzaBuilder setSize(Pizza.Grandeur grandeur)
        {
            throw new NotImplementedException();
        }
    }
}

