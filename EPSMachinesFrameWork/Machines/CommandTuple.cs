using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MachineFrameWork.Machines
{
    public class CommandTuple<T>
    {
        public String Command
        {
            get;
            set;
        }

        public T Value
        {
            get;
            set;
        }

       
    }
}
