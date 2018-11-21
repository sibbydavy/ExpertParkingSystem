using FloorStructure;
using MachineFrameWork.Factory;
using MachineFrameWork.Machines;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AssembleGarage
{
    public class GarageFactory
    {
        List<NormalFloor> normalFloorLayouts = null;
        List<EntryExitFloor> entryexitFloorLayouts = null;

        List<LCM> lcmmachines = null;
        List<UCM> ucmmachines = null;

        ArrayList assembledFloors = null;

        public ArrayList AssembledFloors
        {
            get
            {
                return this.assembledFloors;
            }
            set
            {
                this.assembledFloors = value;
            }
        }

       

        public void AssembleGarage()
        {
            CreateFloors();
            CreateMachines();
            AssignMachineToFloor();

            this.assembledFloors.AddRange(this.normalFloorLayouts);
            //this.assembledFloors.AddRange(this.entryexitFloorLayouts);
        }

        public GarageFactory()
        {
            this.assembledFloors = new ArrayList();
        }

        /// <summary>
        /// Create floors using <c>FloorFactory</c> class. And assign to property named 'normalFloorLayouts' and 'entryexitFloorLayouts' list. 
        ///  'normalFloorLayouts' and 'entryexitFloorLayouts'  are  <c>List<IFloor></c> type.
        /// </summary>
        void CreateFloors()
        {
            FloorFactory floorFactory = new FloorFactory();

            floorFactory.CreateFloor();
            this.normalFloorLayouts = floorFactory.NormalFloors;
            this.entryexitFloorLayouts = floorFactory.EntryExitFloors;

        }

        /// <summary>
        ///  Create machines using <c>MachineFactory</c> class. And assign to property named 'machines' list. 
        ///  'machines' is either LCM or UCM type.
        /// </summary>
        void CreateMachines()
        {
            MachineFactory machineFactory = new MachineFactory();
            machineFactory.CreateMachines();
            this.lcmmachines = machineFactory.LCMs.ToList();
            this.ucmmachines = machineFactory.UCMs.ToList(); 
        }

        void AssignMachineToFloor()
        {

            foreach (var floor in this.normalFloorLayouts)
            {
                floor.UCMs  = this.ucmmachines.Where(r => r.FloorNum == floor.FloorNum).ToList(); //this.machines.Where(r => r.FloorNum == floor.FloorNum);
            }

            //foreach (var floor in this.entryexitFloorLayouts)
            //{
            //    floor.LCMs = this.lcmmachines.Where(r => r.FloorNum == floor.FloorNum).ToList(); ; 
            //}

        }

    }
}
