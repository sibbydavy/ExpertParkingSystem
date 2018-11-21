using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure.Enums
{
    public enum AisleStatus
    {
        Unknown,
        FreeSlot, // Normal,
        PalletBundle,
        CarOccupied,
        Disable,
        NotUsable
    }

    public enum Orientation
    {
        Unknown,
        South,
        North
    }

}
