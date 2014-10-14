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
        public bool KeyboardKeyPressed(string key)
        {
            if (key.Length > 0)
            {
                Debug.WriteLine("Keyboard key is Pressed, which is " + key);
                return true;
            }
            else
            {
                Debug.WriteLine("Keyboard key is not pressed!");
                return false;
            }
        }
    }
}
