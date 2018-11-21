using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MachineFrameWork.Interfaces;

//Hard coded values are
using AliasVal = MachineFrameWork.Properties.EmbeddedVariableValues;
using MachineFrameWork.Factory;
using MachineFrameWork.Machines;

namespace MachineFrameWork.Hepler
{
    /// <summary>
    /// Create instance of list of machines of specified machine type and map the basic machine information
    /// from the tags in xml file. Machine type is identified from the generic type 'T'.
    /// </summary>
    /// <typeparam name="T">'T' is an generic type which must be 'IMachineBase' type.</typeparam>
    public class MapMachineDetailsHelper// <T>// where T : MachineBase
    {
        ////T machineType;

        //public String Channel
        //{ get; set; }

        //public String Name
        //{ get; set; }

        //public String DisplayName
        //{ get; set; }

        //public List<MapMachineDetailsHelper<T>> MapMachineAndNameHelpers
        //{ get; set; }

        //public Int16 FloorNum
        //{ get; set; }
        public MapMachineDetailsHelper()
        {
          
        }

       /// <summary>
       /// Create machine object and map the values from xml file tag to machine object.
       /// </summary>
       /// <returns>Return list of machines as 'IMachineBase' format.</returns>
        public List<UCM> GetUCMMachineDetail()
        {
            MachineObjectCreation t = new MachineObjectCreation();
            
            List<UCM> machines = t.GetUCMMachineInstanceList();  

            // Get map xml file.
            XElement document = XElement.Load(Properties.EmbeddedVariableValues.MachineMapDetailFileFullPath);

            //Get all tags related to specified type of machines from xml.
            var machineConfigValues = from mac in document.Elements(AliasVal.Machine)
                                      where (string)mac.Attribute(AliasVal.Type) == GlobalReference.GetMachineTypeInName<UCM>()
                                      select mac;

            UCM machine = null;
           
            //Iterage thru the tags and assign tag values to the properties of the machine class.
            foreach (XElement tagValue in machineConfigValues)
            {
                machine = t.GetUCMMachineInstance(); 

                machine.FloorNum = Convert.ToInt16(tagValue.Element(AliasVal.FloorNum).Value.Trim());
                machine.MachineNum = Convert.ToInt16(tagValue.Element(AliasVal.MachineNum).Value.Trim());
                machine.MachineName = tagValue.Element(AliasVal.Name).Value.Trim();
                machine.Channel = tagValue.Element(AliasVal.Channel).Value.Trim();
                machine.MachineDisplayName = tagValue.Element(AliasVal.DisplayName).Value.Trim();

                //Assign new records to the list.                
                machines.Add(machine);
            }

            return machines;
        }

        //public List<MapMachineDetailsHelper> GetLCMMap()
        //{
        //    XElement xelement = XElement.Load(@"D:\IbnBatuta Project\ARCPSGUI\FloorUI\bin\Debug\MapMachineAndName.xml");

        //    var xmlmaplcms = from machine in xelement.Elements("Machine")
        //                     where (string)machine.Attribute("Type") == "LCM" 
        //                     select machine;

        //    MapMachineDetailsHelper result = null;
        //    List<MapMachineDetailsHelper> resultslist = new List<MapMachineDetailsHelper>();
        //    foreach (XElement xEle in xmlmaplcms)
        //    {
        //        result = new MapMachineDetailsHelper();
        //        result.Channel = xEle.Element("Channel").Value.Trim();
        //        result.Name = xEle.Element("Name").Value.Trim();
        //        result.DisplayName = xEle.Element("DisplayName").Value.Trim();
        //        result.FloorNum = Convert.ToInt16(xEle.Element("FloorNum").Value.Trim());
        //        resultslist.Add(result);
        //    }

        //    return resultslist;
        //}

        /// <summary>
        /// Map the xml tags in 'MapMachineAndName.xml' file into the <c>MapMachineAndNameHelper</c> class. 
        /// </summary>
        /// <returns>return list of <c>MapMachineAndNameHelper</c></returns>
        /// <include file='MapMachineAndName.xml' path='[@name=""]'/>
        //public List<MapMachineDetailsHelper<T>> GetUCMMap()
        //{
        //    // Get 'MapMachineAndName.xml' file.
        //    XElement xelement = XElement.Load(Properties.EmbeddedVariableValues.MachineMapDetailFileFullPath); // @"D:\IbnBatuta Project\ARCPSFrameWork\ARCPSFrameWorkTest\bin\Debug\MapMachineAndName.xml");

        //    //Get all tags related to UCM machine.
        //    var machineTag = from machine in xelement.Elements(AliasVal.Machine)
        //                     where (string)machine.Attribute(AliasVal.Type) == AliasVal.UCM
        //                     select machine;

        //    MapMachineDetailsHelper result = null;
        //    List<MapMachineDetailsHelper> resultslist = new List<MapMachineDetailsHelper>();

        //    //Iterage thru the tags and assign tag values to the properties of the 'MapMachineAndNameHelper' class.
        //    foreach (XElement xEle in machineTag)
        //    {

        //        result = new MapMachineDetailsHelper();
        //        result.Channel = xEle.Element(AliasVal.Channel).Value.Trim();
        //        result.Name = xEle.Element(AliasVal.Name).Value.Trim();
        //        result.DisplayName = xEle.Element(AliasVal.DisplayName).Value.Trim();
        //        result.FloorNum = Convert.ToInt16(xEle.Element(AliasVal.FloorNum).Value.Trim());

        //        //Assign new records to the list.
        //        resultslist.Add(result);
        //    }

        //    return resultslist;
        //}


        /// <summary>
        /// Create machine object and map the values from xml file tag to machine object.
        /// </summary>
        /// <returns>Return list of machines as 'VLC' format.</returns>
        public List<VLC> GetVLCMachineDetail()
        {
            MachineObjectCreation t = new MachineObjectCreation();

            List<VLC> machines = t.GetVLCMachineInstanceList();

            // Get map xml file.
            XElement document = XElement.Load(Properties.EmbeddedVariableValues.MachineMapDetailFileFullPath);

            //Get all tags related to specified type of machines from xml.
            var machineConfigValues = from mac in document.Elements(AliasVal.Machine)
                                      where (string)mac.Attribute(AliasVal.Type) == GlobalReference.GetMachineTypeInName<VLC>()
                                      select mac;

            VLC machine = null;

            //Iterage thru the tags and assign tag values to the properties of the machine class.
            foreach (XElement tagValue in machineConfigValues)
            {
                machine = t.GetVLCMachineInstance();

                machine.FloorNum = Convert.ToInt16(tagValue.Element(AliasVal.FloorNum).Value.Trim());
                machine.MachineNum = Convert.ToInt16(tagValue.Element(AliasVal.MachineNum).Value.Trim());
                machine.MachineName = tagValue.Element(AliasVal.Name).Value.Trim();
                machine.Channel = tagValue.Element(AliasVal.Channel).Value.Trim();
                machine.MachineDisplayName = tagValue.Element(AliasVal.DisplayName).Value.Trim();

                //Assign new records to the list.                
                machines.Add(machine);
            }

            return machines;
        }

    }
}
