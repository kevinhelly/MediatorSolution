using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        public void ComputerSwitchedOn()
        {
            Debug.WriteLine("Computer is Switched on");
        }
        public void ComputerSwitchedOff()
        {
            Debug.WriteLine("Computer is Switched off");
        }
        public void KeyboardKeyPressed()
        {
            Debug.WriteLine("Keyboard key is Pressed!");
        }
    }
}
