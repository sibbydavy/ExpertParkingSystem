using MachineFrameWork.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Machines
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MachineBase //: SharedLogic.Machine.IMachine // IMachineBase,
    {
        #region Properties

        public Int16 FloorNum
        {
            get;
            set;
        }

        public string Channel
        {
            get;
            set;
        }

        public bool IsMachineInL2
        {
            get;
            set;
        }

        public string MachineName
        {
            get;
            set;
        }

        public String MachineDisplayName
        {
            get;
            set;
        }

        public short MachineNum
        {
            get;
            set;
        }

        public ArrayList CommandTuples
        {
            get;
            set;
        }
        #endregion

        public MachineBase()
        {
            this.CommandTuples = new ArrayList();
        }

        public abstract void CreateCommand();
        public abstract void BindNotification();
        public abstract void UnbindNotification();
     
    }
}
