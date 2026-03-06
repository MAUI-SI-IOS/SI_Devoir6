using Devoir3_builder.data;
using System.Diagnostics;

namespace Devoir3_builder.State
{
    public class Cancelled : IPizzaState
    {
        private Cancelled() { }
        internal static readonly IPizzaState Instance = new Cancelled();
        public void Process(Pizza pizza)
        {
            Debug.WriteLine("La pizza est annulée. Aucune action ne peut être effectuée.");
        }
    }
}
