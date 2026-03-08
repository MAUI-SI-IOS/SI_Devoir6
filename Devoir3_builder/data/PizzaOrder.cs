using Devoir3_builder.Observer;
using Devoir3_builder.State;
using Devoir6.decorator;

namespace Devoir3_builder.data
{
    public class PizzaOrder
    {
        public IPizzaDecorator pizza;
        public IOrderState state;
        private List<INotify> observers = [];



    }
}
