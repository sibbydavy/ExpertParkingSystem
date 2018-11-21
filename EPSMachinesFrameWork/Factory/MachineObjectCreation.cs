using MachineFrameWork.Hepler;
using MachineFrameWork.Interfaces;
using MachineFrameWork.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hard coded values like string, integer, etc.
using AliasVal = MachineFrameWork.Properties.EmbeddedVariableValues;

namespace MachineFrameWork.Factory
{
   public class MachineObjectCreation //where T : IMachineBase
    {
      // T machine;

       public UCM GetUCMMachineInstance()
       {
          UCM  machine =  new UCM();
            //if(GlobalReference.GetMachineTypeInName<T>() == AliasVal.UCM)
            //{
            //   machine =  new UCM();
            //}
            //else if(GlobalReference.GetMachineTypeInName<T>() == AliasVal.LCM)
            //{
            
            //}

           return machine;
       }

       public VLC GetVLCMachineInstance()
       {
           VLC machine = new VLC();
           //if(GlobalReference.GetMachineTypeInName<T>() == AliasVal.UCM)
           //{
           //   machine =  new UCM();
           //}
           //else if(GlobalReference.GetMachineTypeInName<T>() == AliasVal.LCM)
           //{

           //}

           return machine;
       }

       public List<UCM> GetUCMMachineInstanceList()
       {
           //List<object> machines = new List<UCM>().ConvertAll(r => (T) r);

           //machines = new List<UCM>();
           //return machines;

          List<UCM>  machines = new List<UCM>();
          return  machines;
       //   return machines.ConvertAll(r => (T)r);

           //if (GlobalReference.GetMachineTypeInName<T>() == AliasVal.UCM)
           //{
           //    machines = new List<UCM>().ConvertAll(r => (IMachineBase) r);
           //}
           //else if (GlobalReference.GetMachineTypeInName<T>() == AliasVal.LCM)
           //{

           //}
       }

       public List<VLC> GetVLCMachineInstanceList()
       {
           //List<object> machines = new List<UCM>().ConvertAll(r => (T) r);

           //machines = new List<UCM>();
           //return machines;

           List<VLC> machines = new List<VLC>();
           return machines;
           //   return machines.ConvertAll(r => (T)r);

           //if (GlobalReference.GetMachineTypeInName<T>() == AliasVal.UCM)
           //{
           //    machines = new List<UCM>().ConvertAll(r => (IMachineBase) r);
           //}
           //else if (GlobalReference.GetMachineTypeInName<T>() == AliasVal.LCM)
           //{

           //}
       }
    }
}
