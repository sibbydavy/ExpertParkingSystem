using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public abstract class Floor //: IList<IFloor>
    {
       public Int16 FloorNum
       {
           get;
           set;
       }

       public String FloorName
       {
           get;
           set;
       }

       public List<Row> Rows
       {
           get;
           set;
       }

       //List<Machine> Machines
       //{
       //    get;
       //    set;
       //}
    }
}
