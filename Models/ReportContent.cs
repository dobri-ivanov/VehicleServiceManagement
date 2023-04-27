using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    public class ReportContent
    {
        public ReportContent(string title, decimal quantity, decimal price, decimal totalPrice)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public ReportContent(string title, decimal quantity, decimal price)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string Title { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
