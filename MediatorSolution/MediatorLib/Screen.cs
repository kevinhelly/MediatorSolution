using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Screen
    {
        private readonly ComputerSystem _mediator;
        public Screen(ComputerSystem mediator)
        {
            _mediator = mediator;
        }

        public void TurnOn()
        {
            Debug.WriteLine("Screen is turned on");
        }

        public void TurnOff()
        {
            Debug.WriteLine("Screen is turned off");
        }

        public void DisplayCharacter()
        {
            Debug.WriteLine("Screen is displaying characters");
        }
    }
}
