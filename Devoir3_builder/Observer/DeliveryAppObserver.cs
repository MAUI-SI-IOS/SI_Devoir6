using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.Observer
{
    public class DeliveryAppObserver : INotify
    {
        public void Notify(string message)
        {
            Console.WriteLine("delivery app: "+ message);   
        }
    }
}
