/*
   Filename:  MachineFactory.cs
   Author:   Sibby
 */

using MachineFrameWork.Hepler;
using MachineFrameWork.Interfaces;
using MachineFrameWork.Machines;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineFrameWork.Factory
{
   
    /// <summary>
    /// MachineFactory class is reponsible for creating machines and add the created machines
    /// into the the list which has IMachineBase type. The list hold all type of machines. These machine
    /// list is accessable thru properties, if user want specified list of machines that also
    /// accessable thru the list which has that specified type.
    /// </summary>
    /// <remarks>Before calling the machines list property, be sure to Call <c>CreatMachines</c> method.    
    public class MachineFactory
    {
        #region Variables
        /// <summary>
        /// Hold all type of machines that implemented <c>IMachineBase</c> interface.
        /// </summary>
        static ArrayList machines = null;
        #endregion

        #region Properties
      
        /// <summary>
        /// Gets the lcm machines from the collection. This LCM machines list retrieves from
        /// <c>Machines</c> properties by filtering out only LCM type values.
        /// </summary>
        /// <value>LCM Machines</value>
        public List<LCM> LCMs
        {
            get
            {
                List<LCM> lcms = machines.OfType<LCM>().ToList();
                return lcms;
            }
        }

        /// <summary>
        /// Gets the lcm machines from the collection. This UCM machines list retrieves from
        /// <c>Machines</c> properties by filtering out only UCM type values.
        /// </summary>
        /// <value>UCM Machines</value>
        public List<UCM> UCMs
        {
            get
            {
                List<UCM> ucms = machines.OfType<UCM>().ToList();
                return ucms;
            }
        }
        #endregion

        /// <summary>
        /// This method initialize <c>macines</c> list object, create all machines and add into the <c>machines</c> list.
        /// </summary>
        public void CreateMachines()
        {
           // this.machines = new List<IMachineBase>();

            //TODO: uncomment.
            //CreateLCM();
            machines = new ArrayList();
            CreateListOfUCM();
            CreateLisOfVLC();
        }

        void CreateLCM()
        {
            //lcms = new List<LCM>(6);
            //LCM lcm = null;

            //MapMachineDetailsHelper map = new MapMachineDetailsHelper();
            //List<MapMachineDetailsHelper> lstMap = map.GetLCMMap();
            //Int16 counter = 1;

            //foreach (MapMachineDetailsHelper val in lstMap)
            //{
            //    lcm = new LCM();
            //    lcm.Index = counter;
            //    lcm.MachineName = val.Name;
            //    lcm.MachineDisplayName = val.DisplayName;
            //    lcm.Channel = val.Channel;
            //    lcm.FloorNum = val.FloorNum;
            //    //TODO: uncomment
            //    //lcm.CreateCommand();
            //    this.machines.Add(lcm);
            //    counter += 1;
            //}
        }

        /// <summary>
        /// Create all ucm machines, assign values into properties of machine class and created machine 
        /// is add into the <c>machines</c> list.
        /// </summary>
        void CreateListOfUCM()
        {
            MapMachineDetailsHelper mapUCM = new MapMachineDetailsHelper();          
            List<UCM> ucms = mapUCM.GetUCMMachineDetail();
            machines.AddRange(ucms);        
        }

        void CreateLisOfVLC()
        {
            MapMachineDetailsHelper mapVLC = new MapMachineDetailsHelper(); 
            List<VLC> vlcs = mapVLC.GetVLCMachineDetail();
            machines.AddRange(vlcs);  
        }
        
    }
}
