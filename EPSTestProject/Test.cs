using AssembleGarage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   public class Test
    {
       public void TestGarage()
       {
           GarageFactory garage = new GarageFactory();
           garage.AssembleGarage();
       }
    }
}
