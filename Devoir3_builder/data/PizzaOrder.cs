using Devoir3_builder.Observer;
using Devoir3_builder.State;
using Devoir6.decorator;

namespace Devoir3_builder.data
{
    public class PizzaOrder
    {
        public IPizzaDecorator pizza;
        public IOrderState state;
        public List<INotify> observers = []; 
        
        public PizzaOrder(IPizzaDecorator pizza){
          this.pizza = pizza;
          state = Created.Instance;
        }

        public void Notify(string message){
          foreach(var o in observers){
              o.Notify(message);
          }
        }
    }
}
