using Floor.Interfaces;
using FloorStructure.ConfigEntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure
{
    /// <summary>
    /// FloorFactory class is responsible for creating floor strucutre of the entire garage and add the created floor
    /// into the <c>floors</c> list variables which have <c>IFloor</c> datatype. The entire floor structure is 
    /// accessiable thru <c>Floors</c> property.
    /// </summary>
   public class FloorFactory //: IList<IFloor>
    {
        List<NormalFloor> normalFloors;
        List<EntryExitFloor> entryexitFloors;
        //Int16 totalFloor;
        //Int16 totalRow;
        //Int16 totalAisle;
        //Int16 totalRowsInNorth;
        //Int16 totalRowsInSouth;

        public List<NormalFloor> NormalFloors
        {
            get { return this.normalFloors; }
        }

        public List<EntryExitFloor> EntryExitFloors
        {
            get { return this.entryexitFloors; }
        }

        public FloorFactory()
        { 
        
        }

       /// <summary>
       /// Map the xml configuration file of floor into the <c>FloorLayout</c> class. After mapping
       /// these records convert into the <c>IFloor</c> type and assign to the <c>Floors</c> property.
       /// </summary>
        public void CreateFloor()
        {
            MapConfigToClassForFloorStructure mapConfig = new MapConfigToClassForFloorStructure();

            this.normalFloors = mapConfig.GetNormalFloorLayout(); //.ConvertAll(r => (Floor)r);    
            
            //TODO : for entry exit floor.
            //this.entryexitFloors = mapConfig.GetNormalFloorLayout(); //.ConvertAll(r => (Floor)r);    
           
        }


        public void TestCreateFloor()
        {
            MapConfigToClassForFloorStructure mapConfig = new MapConfigToClassForFloorStructure();

       //     this.floors = mapConfig.TestGetFloorLayout().ConvertAll(r => (Floor)r);   
        }

       
    }
}
