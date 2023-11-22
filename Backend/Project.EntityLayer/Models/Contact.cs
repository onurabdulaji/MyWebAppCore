using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Models
{
    public class Contact : IEntity
    {
        public Contact()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ContactID { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactSubject { get; set; }
        public string? ContactMessage { get; set; }
        public bool ContactStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
