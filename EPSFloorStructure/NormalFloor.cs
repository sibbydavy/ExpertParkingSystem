using MachineFrameWork.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
  public  class NormalFloor : Floor
  {
      List<UCM> ucms = null;

      #region Properties
      public List<UCM> UCMs
      {
          get
          {
              return this.ucms;
          }

          set
          {
              this.ucms = value;
          }
      }
      #endregion
  }
}
