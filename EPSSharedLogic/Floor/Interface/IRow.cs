using Floor.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public interface IRow//: IList<IRow>
    {
        Int32 RowNum
        {
            get;
            set;
        }

        RowOrientation RowOrientation
        {
            get;
            set;

        }

        List<ISlot> Slotes
        {
            get;
            set;
        }

    }
}
