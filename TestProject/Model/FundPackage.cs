using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestProject.Model
{
    public enum FundPackage
    {
        [Description("Silver")]
        SILVER ,
        [Description("Gold")]
        GOLD,
        [Description("Platinum")]
        PLATINUM

    }
}
