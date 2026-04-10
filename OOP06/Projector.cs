using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    public class Projector
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Projector is now ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Projector is now OFF.");
        }
    }
}
