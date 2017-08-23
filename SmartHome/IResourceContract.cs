using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    interface IResourceContract
    {
        void GetState();
        void DistributeResourses(IResource resource);
        IResource GetResourseInfo();
    }
}
