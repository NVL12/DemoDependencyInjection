using DemoDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Models
{
    public class SystemDateTime : ISystemDateTime
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
