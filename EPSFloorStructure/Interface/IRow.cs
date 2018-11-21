using Floor.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public class Row//: IList<IRow>
    {
       public Int32 RowNum
        {
            get;
            set;
        }

       public RowOrientation RowOrientation
        {
            get;
            set;

        }

        List<Slot> Slotes
        {
            get;
            set;
        }

    }
}
