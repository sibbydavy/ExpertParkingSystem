using Floor.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public class Slot //: IList<ISlot>
    {
       public Int32 SlotNum
        {
            get;
            set;
        }

       public SlotStatus SlotStatus
        {
            get;
            set;
        }

       public SlotType SlotType
        {
            get;
            set;
        }

       public Shared.Transaction.ITransactionDetail TransactionInfo
        {
            get;
            set;
        }
    }
}
