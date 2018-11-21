using Floor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floor.Enum;

namespace FloorStructure
{
    public class Row //: IRow
    {
        List<Slot> slots = null;
        public List<Slot> Slotes
        {
            get
            {
                return this.slots;
            }
            set
            {
                this.slots = value;
            }
        }

        public RowOrientation RowOrientation
        {
            get;
            set;
        }

        public Int32 RowNum
        {
            get;
            set;
        }

        public Row()
        {
            this.slots = new List<Slot>();
        }

        public static RowOrientation GetRowOrientation(string value)
        {
            RowOrientation rowOrientation = RowOrientation.Unknown;

            if (value.Equals("North"))
            {
                rowOrientation = RowOrientation.North;
            }
            else if (value.Equals("South"))
            {
                rowOrientation = RowOrientation.South;
            }

            return rowOrientation;

        }


    }
}
