using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public enum Category
    {
        [Description("Technology stuff")]
        TECH,
        [Description("Science stuff")]
        SCIENCE,
        [Description("Car stuff")]
        Cars,
        [Description("Video Games stuff")]
        Video_Games,
        [Description("Other")]
        OTHER



    }
}
