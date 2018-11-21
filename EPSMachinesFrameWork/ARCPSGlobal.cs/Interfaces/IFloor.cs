using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources.Interfaces
{
   public interface IFloor
    {
       Int16 FloorNum
       {
           get;
           set;
       }

       Int16 RowNum
       {
           get;
           set;
       }

       Int32 AisleNum
       {
           get;
           set;
       }
    }
}
