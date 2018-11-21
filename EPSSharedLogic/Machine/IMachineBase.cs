using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLogic.Machine
{
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


        String MachineDisplayName
        {
            get;
            set;
        }
    }
}
