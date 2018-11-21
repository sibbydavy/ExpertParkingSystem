using FloorStructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure.Interfaces
{
   public interface IRow
    {
        String RowNum
        {
            get;
            set;
        }

        Orientation Orientation
        {
            get;
            set;

        }
    }
}
