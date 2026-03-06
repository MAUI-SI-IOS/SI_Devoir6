// See https://aka.ms/new-console-template for more information
using Devoir3_builder.builder;
using Devoir3_builder.data;
using System.Diagnostics;
test();


void test()
{
    Director director;
    Pizza pizza;

    //colombienne
    PizzaColombienneBuilder colombienneBuilder = new PizzaColombienneBuilder();
    director = new Director(colombienneBuilder);
    pizza = director.make();

    Debug.Assert("pate colombienne, sauce colombienne, garnitures colombienne" == pizza.ToString());

    //italien
    PizzaItalienneBuilder italienBuilder = new PizzaItalienneBuilder();
    director = new Director(italienBuilder);
    pizza = director.make();

    Debug.Assert("pate italien, sauce italien, garnitures italien" == pizza.ToString());

    //espagnol
    PizzaHawaiienneBuilder espagnolBuilder = new PizzaHawaiienneBuilder();
    director = new Director(espagnolBuilder);
    pizza = director.make();

    Debug.Assert("pate espagnol, sauce espagnol, garnitures espagnol" == pizza.ToString());
    
    //senegalaise
    PizzaSenegalaiseBuilder senegalBuilder = new PizzaSenegalaiseBuilder();
    director = new Director(senegalBuilder);
    pizza = director.make();

    Debug.Assert("pate senegalaise, sauce senegalaise, garnitures senegalaise" == pizza.ToString());
}