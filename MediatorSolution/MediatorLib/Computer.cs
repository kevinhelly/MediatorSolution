using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Computer
    {
        private readonly ComputerSystem _mediator;

        public Computer(ComputerSystem mediator)
        {
            _mediator = mediator;
        }
        public void SwitchOn()
        {

        }
        public void SwitchOff()
        {

        }
    }
}
