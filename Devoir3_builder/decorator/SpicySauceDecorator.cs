




namespace Devoir6.decorator;

public class SpicySauceDecorator: IPizzaDecorator {

  public IPizzaDecorator pizza {get;set;}
 
  public SpicySauceDecorator(IPizzaDecorator pizza){
    this.pizza = pizza;
  }
  public int GetPrice(){
    return pizza.GetPrice() + 10;
  }
  public string GetDescription(){
    return "spicy sauce" + pizza.GetDescription();
  }
}
