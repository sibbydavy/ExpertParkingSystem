using Floor.Enum;
using Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Interfaces
{
   public interface ISlot //: IList<ISlot>
    {
        Int32 SlotNum
        {
            get;
            set;
        }

        SlotStatus SlotStatus
        {
            get;
            set;
        }

        SlotType SlotType
        {
            get;
            set;
        }

        //ISlot Slots
        //{
        //    get;
        //    set;
        //}

        ITransactionDetail TransactionInfo
        {
            get;
            set;
        }
    }
}
