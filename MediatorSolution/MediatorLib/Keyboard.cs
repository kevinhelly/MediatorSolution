﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        private readonly ComputerSystem _mediator;
        public Keyboard(ComputerSystem mediator)
        {
            _mediator = mediator;
        }

        public void Enabled()
        {
            Debug.WriteLine("Keyboard is enabled");
        }

        public void Disabled()
        {
            Debug.WriteLine("Keyboard is enabled");
        }

        public bool KeyPressed(string key)
        {
            return _mediator.KeyboardKeyPressed(key);
        }

        
    }
}
