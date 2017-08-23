using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IMenu
    {
        void ManageLight();
        void ManageTemperature();
        void ManageMultimedia();
        void ManageHumidity();
        void ManageFood();
        void ManageWater();
        void ManageElectricity();
    }
}
