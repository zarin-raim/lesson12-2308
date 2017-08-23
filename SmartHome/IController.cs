using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IController
    {
        /* Get-set properties level  */

        double Light { get; set; }
        
        double Temperature { get; set; }

        double Humidity { get; set; }

        double Water { get; set; }

        int Food { get; set; }

        double Electricity { get; set; }
    }
}
