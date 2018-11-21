using Floor.Interfaces;
using FloorStructure;
using MachineFrameWork.Factory;
using MachineFrameWork.Interfaces;
using MachineFrameWork.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
    public class GarageFactory
    {

        List<Floor> floorLayouts = null;
        List<MachineBase> machines = null;

        public List<Floor> AssembledFloors
        {
            get
            {
                return this.floorLayouts;
            }
            set
            {
                this.floorLayouts = value;
            }
        }

        public void AssembleGarage()
        {
           FloorStructure.Floor 
            AssignMachineToFloor();
        }

        public GarageFactory()
        {
            // this.FloorNum = floorNum;
        }

        /// <summary>
        ///  Create machines using <c>MachineFactory</c> class. And assign to property named 'machines' list. 'machines' is a <c>List<IMachineBase></c> type.
        /// </summary>
        void CreateMachines()
        {
            MachineFactory machineFactory = new MachineFactory();
            machineFactory.CreateMachines();
            this.machines = machineFactory.Machines.ToList(); 
        }

        void AssignMachineToFloor()
        {        

            foreach (var floor in this.floorLayouts)
            {
                floor.Machines = this.machines; //this.machines.Where(r => r.FloorNum == floor.FloorNum);
            }


        }

    }
}
