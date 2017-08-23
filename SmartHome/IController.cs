using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    interface IController
    {
        double Light { get; set; }
        double Temperature { get; set; }
        double Humidity { get; set; }

        

    }
}
