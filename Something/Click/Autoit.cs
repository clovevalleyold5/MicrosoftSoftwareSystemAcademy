using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace Click
{
    class Autoit
    {
        AutoItX3 auto = new AutoItX3();
        public void mClick(string side, int x, int y, int times, int speed)
        {
            auto.MouseClick(side, x, y, times, speed);
        }
        public void kClick()
        {
            auto.Send("{LCTRL down}");
            auto.Send("{TAB down}");
            auto.Send("{TAB up}");
            auto.Send("{LCTRL up}");
            auto.Sleep(500);
        }
    }
}
