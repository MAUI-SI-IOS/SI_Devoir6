using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaColombienneBuilder : IPizzaBuilder
    {
        Pizza pizza;

        public PizzaColombienneBuilder()
        {
            this.pizza = new Pizza();
        }

        public IPizzaBuilder makeDough()
        {
            this.pizza.setPate("pate colombienne");
            return this;
        }

        public IPizzaBuilder makeSauce()
        {
            this.pizza.setSauce("sauce colombienne");
            return this;
        }

        public IPizzaBuilder makeToppings()
        {
            this.pizza.setGarniture("garnitures colombienne");
            return this;
        }

        public IPizzaBuilder makePrix()
        {
            this.pizza.setPrix(20);
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
