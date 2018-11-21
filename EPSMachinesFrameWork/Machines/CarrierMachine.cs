using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Machines
{
   public class CarrierMachine : MachineBase
    {
       public CarrierMachine()
           :base()
       {
       
       }
     
       public override void CreateCommand()
       {
           //Move command.
           CommandTuple<Boolean> cmdMove = new CommandTuple<Boolean>() { Command = MachineCommands.CarrierMachineCommands.Move, Value = false };
           base.CommandTuples.Add(cmdMove);

           //Get command.
           CommandTuple<Boolean> cmdGet = new CommandTuple<Boolean>() { Command = MachineCommands.CarrierMachineCommands.Get, Value = false };
           base.CommandTuples.Add(cmdGet);

           //Put command.
           CommandTuple<Boolean> cmdPut = new CommandTuple<Boolean>() { Command = MachineCommands.CarrierMachineCommands.Put, Value = false };
           base.CommandTuples.Add(cmdPut);

           //Command Done command.
           CommandTuple<Boolean> cmdDone = new CommandTuple<Boolean>() { Command = MachineCommands.CarrierMachineCommands.CommandDone, Value = true };
           base.CommandTuples.Add(cmdDone);


           //Current Aisle command.
           CommandTuple<Int16> cmdCurAisle = new CommandTuple<Int16>() { Command = MachineCommands.CarrierMachineCommands.CurrentAisle, Value = 0 };
           base.CommandTuples.Add(cmdCurAisle);

           //Destination Aisle command.
           CommandTuple<Int16> cmdDestAisle = new CommandTuple<Int16>() { Command = MachineCommands.CarrierMachineCommands.DestinationAisle, Value = 0 };
           base.CommandTuples.Add(cmdDestAisle);
           

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
