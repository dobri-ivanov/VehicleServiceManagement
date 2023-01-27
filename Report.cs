using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    class Report
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int ClientID { get; set; }
        public int VehicleID{ get; set; }
        public decimal WorkPrice { get; set; }
        public decimal TotalSum { get; set; }

    }
}
