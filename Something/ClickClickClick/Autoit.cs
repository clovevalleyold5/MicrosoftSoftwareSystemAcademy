using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace ClickClickClick
{
    class Autoit
    {
        AutoItX3 auto = new AutoItX3();
        public void mClick(string strButton, int nX, int nY, int nClicks, int nSpeed)
        {
            auto.MouseClick(strButton, nX, nY, nClicks, nSpeed);
        }
    }
}
