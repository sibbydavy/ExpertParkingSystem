using MachineFrameWork.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.MachineFrameWork
{
   public class MachineTest
    {
       public void CreateMachines()
       { 
          MachineFactory mfact = new MachineFactory();
           mfact.CreateMachines();
           Console.Read();
       }
    }
}
