using Floor.Enum;
using Floor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FloorStructure.ConfigEntityClass
{
   public class MapConfigToClassForFloorStructure
    {
       public List<NormalFloor> GetNormalFloorLayout()
       {
           //List<FloorLayout> result = null;

           var path = Assembly.GetExecutingAssembly().Location;
           path = path.Substring(0, path.LastIndexOf('\\')) + "\\ConfigurationXML\\" + "FloorConfiguration.xml";
           XDocument xmlDoc = XDocument.Load(path);
           
           var floorstruct = from floor in xmlDoc.Descendants("Floor")
                             select new NormalFloor
                             {
                                 FloorName = Convert.ToString(floor.Element("FloorName").Value),
                                 FloorNum = Convert.ToInt16(floor.Element("FloorNum").Value),                               
                                 Rows = new List<Row>(from row in floor.Descendants("Row")
                                                      select new Row
                                                      {
                                                          RowNum = Convert.ToInt32(row.Element("RowNum").Value),
                                                          RowOrientation = Row.GetRowOrientation(row.Element("RowOrientation").Value.Trim()),
                                                          Slotes = new List<Slot>(from slot in row.Descendants("Slot")
                                                                                   select new Slot
                                                                                   {
                                                                                       SlotNum = Convert.ToInt32(slot.Element("SlotNum").Value.Trim()),
                                                                                       SlotType = Slot.GetSlotType(Convert.ToString(slot.Element("SlotType").Value.Trim())),
                                                                                       SlotStatus = SlotStatus.Unknown
                                                                                   })
                                                      })
                             };

           return floorstruct.ToList();
       }

       public List<NormalFloor> TestGetFloorLayout()
       {

           List<NormalFloor> floors = new List<NormalFloor>();

           NormalFloor floor = null;
           Row row = null;
           Slot slot = null;
           List<Slot> slots = new List<Slot>();
           List<Row> rows = new List<Row>();


           int slotNum = 1;
           for (int f = 1; f <= 1; f++)
           {
               floor = new NormalFloor();
               floor.FloorName = "Upper Floor 1";
               floor.FloorNum = 1;

               for (int r = 1; r <= 4; r++)
               {
                   row = new Row();
                   row.RowNum = r;

                   if (r > 3)
                       row.RowOrientation = global::Floor.Enum.RowOrientation.North;
                   else
                       row.RowOrientation = global::Floor.Enum.RowOrientation.South;
                   row.RowNum = r;

                   for (int s = 1; s <= 32; s++)
                   {
                       slot = new Slot();

                       slot.SlotNum = slotNum;
                       //slotNum +=1;
                       if (r == 2 && (s == 8 || s == 12 || s == 15 || s == 18 || s == 22))
                       {
                           slot.SlotType = global::Floor.Enum.SlotType.VLC;
                           slot.SlotStatus = global::Floor.Enum.SlotStatus.NotUsable;
                       }
                       else if((r == 3 && (s == 6 || s == 16 || s == 26 )))
                       {
                           slot.SlotType = global::Floor.Enum.SlotType.PVL;
                           slot.SlotStatus = global::Floor.Enum.SlotStatus.NotUsable;
                       }
                       else if ((r == 4 && (s == 6 || s == 16 || s == 122)))
                       {
                           slot.SlotType = global::Floor.Enum.SlotType.ElectricalRoom;
                           slot.SlotStatus = global::Floor.Enum.SlotStatus.NotUsable;
                       }
                       else 
                       {
                           slot.SlotType = SlotType.ValidSlot;
                           slot.SlotStatus = global::Floor.Enum.SlotStatus.FreeSlot;
                           slotNum += 1;
                       }
                     
                       row.Slotes.Add(slot);
                   }
                   floor.Rows.Add(row);                         
               }

               floors.Add(floor);
           }

          return floors.ToList();
       }

      
    }


}
