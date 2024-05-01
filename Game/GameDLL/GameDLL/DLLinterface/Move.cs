using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.DLLinterface
{
    public interface Move
    {
        Point move(Point location);
    }
}
