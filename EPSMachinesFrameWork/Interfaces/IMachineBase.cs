using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Interfaces
{
    /// <summary>
    /// This is base interface for all type machines.
    /// </summary>
   public interface IMachineBase
    {
        String Channel
        {
            get;
            set;
        }

        String MachineName
        {
            get;
            set;
        }

        Boolean IsMachineInL2
        {
            get;
            set;
        }

        Int16 FloorNum
        {
            get;
            set;
        }

        Int16 MachineNum
        {
            get;
            set;
        }

        String MachineDisplayName
        {
            get;
            set;
        }

        ArrayList CommandTuples
        {
            get;
            set;
        }
    }
}
