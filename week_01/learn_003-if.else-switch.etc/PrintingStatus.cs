using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switches
{
    public enum PrintingStatus
    {
        Idle,
        Starting,
        Loading,
        Printing,
        Cleaning,
        Stopping
    }
}
