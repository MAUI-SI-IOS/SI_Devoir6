using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaSenegalaiseBuilder : IPizzaBuilder
    {
        Pizza pizza;
        public PizzaSenegalaiseBuilder()
        {
            pizza = new Pizza();
        }
        public IPizzaBuilder makeDough()
        {
            this.pizza.setPate("pate senegalaise");
            return this;
        }

        public IPizzaBuilder makeSauce()
        {
            this.pizza.setSauce("sauce senegalaise");
            return this;
        }

        public IPizzaBuilder makeToppings()
        {
            this.pizza.setGarniture("garnitures senegalaise");
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
