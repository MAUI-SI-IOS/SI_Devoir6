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
  Console.WriteLine("Pizza ordered: "+finalPizza.GetDescription()+"prix total: "+finalPizza.GetPrice());

  var order  = new PizzaOrder(finalPizza);

  //3- attacher 3 observer 
  var customerApp = new CustomerAppObserver();
  var deliveryApp = new DeliveryAppObserver();
  var kitchenScreen = new KitchenScreenObserver();

  order.observers.Add(customerApp);
  order.observers.Add(deliveryApp);
  order.observers.Add(kitchenScreen);


  //4- faire la chain & executer la chain
  var orderHandler = new ValidateOrderHandler();
  var prepareHandler = new PrepareHandler();
  var bakeHandler = new BakeHandler();
  var cutHandler = new CutHandler();
  var packHandler = new PackHandler();
  var dispatchHandler = new DispatchHandler(); 
  packHandler.Next = dispatchHandler;
  cutHandler.Next = packHandler;
  bakeHandler.Next = cutHandler;
  prepareHandler.Next = bakeHandler;
  orderHandler.Next = prepareHandler;

  orderHandler.Handle(order);
  
  Console.WriteLine("------------- Done --------------");

}
