using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ComputerSystem computerSystem = new ComputerSystem();
            Computer computer = new Computer(computerSystem);
            Screen screen = new Screen(computerSystem);
            Keyboard keyboard = new Keyboard(computerSystem);

            computer.SwitchOn();
            if (keyboard.KeyPressed("2"))
            {
                screen.DisplayCharacter();
            }
        }
    }
}
