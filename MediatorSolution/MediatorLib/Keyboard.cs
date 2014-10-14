using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    class Keyboard
    {
        private readonly ComputerSystem _mediator;
        public Keyboard(ComputerSystem mediator)
        {
            _mediator = mediator;
        }

        public void Enabled()
        {
            
        }

        public void Disabled()
        {
            
        }

        public void KeyPressed()
        {
            _mediator.KeyboardKeyPressed();
        }

        
    }
}
