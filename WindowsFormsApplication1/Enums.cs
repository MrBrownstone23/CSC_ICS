using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Enums
    {
        public enum EnumTransactionType
        {
            [Description("Receive")]
            Receive = 1,

            [Description("Ship")]
            Ship = 2,

            [Description("Shrinkage")]
            Shrinkage = 3,

            [Description("Take")]
            Take = 4         

        }

        public enum EnumReason
        {
            [Description("Service Call")]
            ServiceCall = 1,

            [Description("Not Used")]
            NotUsed = 2,

            [Description("Ship To Customer")]
            ShipToCustomer = 3


        }
        

    }
}
