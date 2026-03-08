using Devoir3_builder.data;
using Devoir3_builder.Data;

namespace Devoir3_builder.Handler
{
    public interface IPizzaHandler
    {
        IPizzaHandler Next { set; }
        PizzaOrder Handle(PizzaOrder order);
    }
}
