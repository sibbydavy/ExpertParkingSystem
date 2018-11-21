using FloorStructure.Enums;
using SharedResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorStructure.Interfaces
{
   public interface IAisle
    {
        Int32 AisleNum
        {
            get;
            set;
        }

        AisleStatus Status
        {
            get;
            set;
        }

        SharedTransactionInfo TransactionInfo
        {
            get;
            set;
        }
    }
}
