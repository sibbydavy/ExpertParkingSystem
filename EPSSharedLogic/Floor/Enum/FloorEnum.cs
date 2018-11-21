using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor.Enum
{
    public enum SlotStatus
    {
        Unknown,
        FreeSlot, // Normal,
        PalletBundle,
        CarOccupied,
        Disable,
        NotUsable
    }

    public enum SlotType
    { 
      Unknown,
      VLC,
      PVL,
      ElectricalRoom,
      EES,
      ValidSlot,
      InvalidSlot
    }


    public enum RowOrientation
    {
        Unknown,
        South,
        North
    }

}
