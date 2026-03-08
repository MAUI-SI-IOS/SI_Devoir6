using Devoir3_builder.data;

namespace Devoir3_builder.State
{
    public interface IOrderState
    {
        void Process(PizzaOrder order);
    }
}
