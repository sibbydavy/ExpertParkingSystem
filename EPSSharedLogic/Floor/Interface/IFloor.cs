using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public interface IFloor //: IList<IFloor>
    {
       Int16 FloorNum
       {
           get;
           set;
       }

       String FloorName
       {
           get;
           set;
       }

       List<IRow>  Rows
       {
           get;
           set;
       }

       //IFloor Floors
       //{
       //    get;
       //    set;
       //}

       //List<IMachineBase> Machines
       //{
       //    get;
       //    set;
       //}
    }
}
