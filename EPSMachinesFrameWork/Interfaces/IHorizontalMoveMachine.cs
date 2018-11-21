using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
   public interface IHorizontalMoveMachine
    {
        Int16 MinWindow
        {
            get;
            set;
        }

        Int16 MaxWindow
        {
            get;
            set;
        }

        Int16  CurrentAisle
        {
            get;
            set;
        }

        Int16 DestinationAisle
        {
            get;
            set;
        }

        Int16 DestinationRow
        {
            get;
            set;
        }
        
        Int16 MinPhysicalLimitWindow
        {
            get;
            set;
        }

        Int16 MaxPhysicalLimitWindow
        {
            get;
            set;
        }

        //Int16 FloorNum
        //{
        //    get;
        //    set;
        //}
    }
}
