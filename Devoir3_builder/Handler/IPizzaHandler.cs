using Devoir3_builder.data;

namespace Devoir3_builder.Handler
{
    public interface IPizzaHandler
    {
        IPizzaHandler Next { set; }
        PizzaOrder Handle(PizzaOrder order);
    }
}
