using Floor.Interfaces;
using Floor.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
    public class Slot //: ISlot
    {
        public int SlotNum
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

        /// <summary>
        /// This hold the object for which the slot is allocated.
        /// The object may be VLC, ELECTRICAL ROOM, EES, etc...
        /// </summary>
        public Object ObjectOnSlot
        {
            get;
            set;
        }



        public Slot()
        { 
        
        }
        
        public static SlotType GetSlotType(string value)
        {
            SlotType slotType = SlotType.Unknown;

            if (value.Equals("VLC"))
            {
                slotType = SlotType.VLC;
            }
            else if (value.Equals("PVL"))
            {
                slotType = SlotType.PVL;
            }
            else if (value.Equals("EES"))
            {
                slotType = SlotType.EES;
            }
            else if (value.Equals("ElectricalRoom"))
            {
                slotType = SlotType.ElectricalRoom;
            }
            else if (value.Equals("ValidSlot"))
            {
                slotType = SlotType.ValidSlot;
            }
            else if (value.Equals("InvalidSlot"))
            {
                slotType = SlotType.InvalidSlot;
            }

            return slotType;

        }

        public Shared.Transaction.ITransactionDetail TransactionInfo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


    }
}
