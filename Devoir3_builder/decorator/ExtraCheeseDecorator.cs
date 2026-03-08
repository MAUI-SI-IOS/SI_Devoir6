


namespace Devoir6.decorator;

public class ExtraCheeseDecorator: IPizzaDecorator {

  public IPizzaDecorator pizza {get;set;}
 
  public ExtraCheeseDecorator(IPizzaDecorator pizza){
    this.pizza = pizza;
  }
  public int GetPrice(){
    return pizza.GetPrice() + 10;
  }
  public string GetDescription(){
    return "extra cheese" + pizza.GetDescription();
  }
}
