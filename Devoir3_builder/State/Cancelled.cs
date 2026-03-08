using Devoir3_builder.data;
using System.Diagnostics;

namespace Devoir3_builder.State
{
    public class Cancelled : IOrderState
    {
        private Cancelled() { }
        internal static readonly IOrderState Instance = new Cancelled();

        public void Process(PizzaOrder order)
        {
            Debug.WriteLine("La pizza est annulée. Aucune action ne peut être effectuée.");
        }
    }
}
