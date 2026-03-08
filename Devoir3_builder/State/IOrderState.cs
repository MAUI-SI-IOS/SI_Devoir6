using Devoir3_builder.Data;

namespace Devoir3_builder.State
{
    public interface IOrderState
    {
        void Process(PizzaOrder order);
    }
}
