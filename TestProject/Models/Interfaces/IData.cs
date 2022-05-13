using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public interface IData
    {
        int Time { get; set; }
        int Human { get; set; }
        int Car { get; set; }
        int Bike { get; set; }
        int Truck { get; set; }
        int Bus { get; set; }
        int Taxi { get; set; }
    }
}
