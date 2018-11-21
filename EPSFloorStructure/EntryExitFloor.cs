using MachineFrameWork.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
	public class EntryExitFloor : Floor
    {
		  List<LCM> lcms = null;

          #region Properties
          public List<LCM> LCMs
          {
              get
              {
                  return this.lcms;
              }
              set
              {
                  this.lcms = value;
              }
          }

          #endregion

    }
}
