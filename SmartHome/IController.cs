﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IController
    {
        double GetSignal();
        void SetValue();
    }
}
