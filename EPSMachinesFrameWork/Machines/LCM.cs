using MachineFrameWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Machines
{
   public class LCM : CarrierMachine, IHorizontalMoveMachine
    {
      
        public override void CreateCommand()
        {
            base.CreateCommand();

            //Rotate command.
            CommandTuple<Boolean> cmdRotate = new CommandTuple<Boolean>() { Command = MachineCommands.LCMCommands.Rotate, Value = false };
            base.CommandTuples.Add(cmdRotate);

            //Rotate Done command.
            CommandTuple<Boolean> cmdRotateDone = new CommandTuple<Boolean>() { Command = MachineCommands.LCMCommands.RotateDone, Value = true };
            base.CommandTuples.Add(cmdRotateDone);

        }

        public override void BindNotification()
        {
            throw new NotImplementedException(); 
            //add a periodic data callback group and add one item to the group
            /* OPCDA.NET.RefreshEventHandler dch = new OPCDA.NET.RefreshEventHandler(GetAlert);
            uGrp = new OPCDA.NET.RefreshGroup(ARCPSGUI.OPC.OPCServerManagement.opcServer, DAUpdateRate, dch);
            int rtc = ARCPSGUI.OPC.OPCServerManagement.rtc;
            OPCServerDirector opcd = new OPCServerDirector(); */

            //create fire alarm.
            //rtc = uGrp.Add("CH433.EES_FLR4_03.FireAlarm");
        }

        public override void UnbindNotification()
        {
            throw new NotImplementedException();
        }
       

        public short MinWindow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public short MaxWindow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public short CurrentAisle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public short DestinationAisle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public short DestinationRow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }



        public short MinPhysicalLimitWindow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public short MaxPhysicalLimitWindow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
