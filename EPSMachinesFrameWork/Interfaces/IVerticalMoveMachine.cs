using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Interfaces
{
    public interface IVerticalMoveMachine
    {
        Int16 CurrentFloor
        {
            get;
            set;
        }

        Int16 DestinationFloor
        {
            get;
            set;
        }
    }
}
