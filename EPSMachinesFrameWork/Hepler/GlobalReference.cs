using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Hepler
{
   public static class GlobalReference
    {

       public static string GetMachineTypeInName<T>()
       {
           string result = "";

           result = typeof(T).Name;

           return result;
       }
    }
}
