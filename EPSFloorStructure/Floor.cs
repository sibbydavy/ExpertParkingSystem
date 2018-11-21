
using Floor.Interfaces;
using MachineFrameWork.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
   public abstract class Floor //: Floor
   {
       List<Row> rows = null;
     
      
      
       #region Properties
       public string FloorName
        {
            get;
            set;
        }

        public short FloorNum
        {
            get;
            set;
        }

        public List<Row> Rows
        {
            get {
                return this.rows;
            }
            set {
                this.rows = value;
            }
        }

      

        //public List<T> Machines<T>//List<SharedLogic.Machine.IMachine> Machines
        //{
        //    get;
        //    set;
        //}

       //public T GetMachines<T>(T )
       // public void AddMachine<T>(T machine)
       // {
       //     if (typeof(T) == typeof(LCM))
       //     {
       //         LCM lcm = (LCM)Convert.ChangeType(machine, typeof(LCM));
       //         lcms.Add(lcm);
       //     }
       //     else if (typeof(T) == typeof(UCM))
       //     {
       //         UCM ucm = (UCM)Convert.ChangeType(machine, typeof(UCM));
       //         ucms.Add(ucm);
       //     }
       // }

        public Floor()
        {
            this.rows = new List<Row>();
        }

       #endregion


   }
}
