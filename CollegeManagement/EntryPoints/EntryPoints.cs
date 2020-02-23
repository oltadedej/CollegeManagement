using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeManagement.EntryPoints
{
    public class EntryPoints<ServiceType>
    {
        public static ServiceType Service
        {
            get { return (ServiceType)Activator.CreateInstance(typeof(ServiceType)); }
        }
    }

}