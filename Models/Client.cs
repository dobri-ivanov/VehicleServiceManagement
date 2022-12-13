using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    public class Client
    {
        public Client(int id, string name, string lastName, string phoneNumber, string nickname)
        {
            ID = id;
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Nickname = nickname;
        }
        public Client(int id, string name, string lastName, string phoneNumber)
        {
            ID = id;
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nickname { get; set; }
    }
}
