using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaHawaiienneBuilder : IPizzaBuilder
    {
        Pizza pizza;

        public PizzaHawaiienneBuilder()
        {
            this.pizza = new Pizza();
        }
        public IPizzaBuilder makeDough()
        {
            this.pizza.setPate("pate Hawaiienne");
            return this;
        }

        public IPizzaBuilder makeSauce()
        {
            this.pizza.setSauce("sauce Hawaiienne");
            return this;
        }

        public IPizzaBuilder makeToppings()
        {
            this.pizza.setGarniture("garnitures Hawaiienne");
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
