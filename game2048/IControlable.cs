using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace game2048
{
    interface IControlable
    {
        void toLeft();
        void toRight();
        void toUp();
        void toDown();
    }
}
