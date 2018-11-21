using MachineFrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Machines
{
    public class UCM : CarrierMachine, IHorizontalMoveMachine
    {
        public UCM()
            : base()
        { 
        
        }
        public short MinWindow
        {
            get;
            set;
        }

        public short MaxWindow
        {
            get;
            set;
        }

        public short CurrentAisle
        {
            get;
            set;
        }

        public short DestinationAisle
        {
            get;
            set;
        }

        public short DestinationRow
        {
            get;
            set;
        }

        public short MinPhysicalLimitWindow
        {
            get;
            set;
        }

        public short MaxPhysicalLimitWindow
        {
            get;
            set;
        }
    }
}
