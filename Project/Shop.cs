using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Course_project
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }
        public string Ownership { get; set; }
        public string WorkTime { get; set; }
        public Shop(int id, string name, string address, string phone, string specialization, string ownership, string work_time)
        {
            ID = id;
            Name = name;
            Address = address;
            Phone = phone;
            Specialization = specialization;
            Ownership = ownership;
            WorkTime = work_time;
        }
    }
}