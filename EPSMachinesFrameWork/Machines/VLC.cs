using MachineFrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Machines
{
    public class VLC : MachineBase, IVerticalMoveMachine
    {

        public short CurrentFloor
        {
            get;
            set;
        }

        public short DestinationFloor
        {
            get;
            set;
        }

        public override void CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override void BindNotification()
        {
            throw new NotImplementedException();
        }

        public override void UnbindNotification()
        {
            throw new NotImplementedException();
        }
    }
}
