




namespace Devoir6.decorator;

public class GluttenFreeDecorator: IPizzaDecorator {

  public IPizzaDecorator pizza {get;set;}
 
  public GluttenFreeDecorator(IPizzaDecorator pizza){
    this.pizza = pizza;
  }
  public int GetPrice(){
    return pizza.GetPrice() + 10;
  }
  public string GetDescription(){
    return "glutten free" + pizza.GetDescription();
  }
}
