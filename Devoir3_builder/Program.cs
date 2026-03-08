// See https://aka.ms/new-console-template for more information
using Devoir3_builder.builder;
using Devoir3_builder.data;
using Devoir3_builder.Handler;
using Devoir6.decorator;
using Devoir3_builder.Observer;

test();


void test()
{

  //1- construire une pizza
  var colombienneBuilder = new PizzaColombienneBuilder();
  var director = new Director(colombienneBuilder);
  var simplePizza = director.make();

  //2- ajouter 2 extra Decorator
  var cheesyPizza = new ExtraCheeseDecorator(simplePizza); 
  var finalPizza  = new GluttenFreeDecorator(cheesyPizza); 
  Console.WriteLine("Pizza ordered"+finalPizza.GetDescription());

  var order  = new PizzaOrder(finalPizza);

  //3- attacher 3 observer 
  var customerApp = new CustomerAppObserver();
  var deliveryApp = new DeliveryAppObserver();
  var kitchenScreen = new KitchenScreenObserver();

  order.observers.Add(customerApp);
  order.observers.Add(deliveryApp);
  order.observers.Add(kitchenScreen);


  //4- faire la chain & executer la chain
  var _1 = new ValidateOrderHandler();
  var _2 = new PrepareHandler();
  var _3 = new BakeHandler();
  var _4 = new CutHandler();
  var _5 = new PackHandler();
  var _6 = new DispatchHandler(); 
  _5.Next = _6;
  _4.Next = _5;
  _3.Next = _4;
  _2.Next = _3;
  _1.Next = _2;

  _1.Handle(order);
  
  Console.WriteLine("------------- Done --------------");

}
