



namespace Devoir6.decorator;

public class StuffedCrustDecorator: IPizzaDecorator {

  public IPizzaDecorator pizza {get;set;}
 
  public StuffedCrustDecorator(IPizzaDecorator pizza){
    this.pizza = pizza;
  }
  public int GetPrice(){
    return pizza.GetPrice() + 10;
  }
  public string GetDescription(){
    return "stuffedCrust" + pizza.GetDescription();
  }
}
