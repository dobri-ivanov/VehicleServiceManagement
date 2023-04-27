using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    class Report
    {
        public Report(int id, string title, string creationDate, string licensePlate)
        {
            this.ID = id;
            this.Title = title;
            this.CreationDate = creationDate;
            this.VehicleLicensePlate = licensePlate;
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string VehicleLicensePlate{ get; set; }
        public decimal WorkPrice { get; set; }
        public decimal TotalSum { get; set; }

    }
}
