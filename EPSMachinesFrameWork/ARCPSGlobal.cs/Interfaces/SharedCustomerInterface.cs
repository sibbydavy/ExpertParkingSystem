using SharedResources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources.Interfaces
{
   public interface SharedTransactionInfo
    {
       String CardId
       {
           get;
           set;
       }

       String PlateNum
       {
           get;
           set;
       }

       String Name
       {
           get;
           set;
       }

       Boolean HasRotated
       {
           get;
           set;
       }

       CarType CarType
       {
           get;
           set;
       }

       String Kiosk
       {
           get;
           set;
       }

       DateTime EntryTime
       {
           get;
           set;
       }

       String EntryEES
       {
           get;
           set;
       }

       String EntryNorthCarPhotoPath
       {
           get;
           set;
       }

       String EntrySouthCarPhotoPath
       {
           get;
           set;
       }






    }


}
