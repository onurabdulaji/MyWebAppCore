using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Models
{
    public class Service : IEntity
    {
        public Service()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ServiceID { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceSubTitle { get; set; }
        public string? ServiceDescriptionOne { get; set; }
        public string? ServiceDescriptionTwo { get; set; }
        public string? ServiceDescriptionThree { get; set; }
        public string? ServiceDescriptionFour { get; set; }
        public string? ServiceDescriptionFive { get; set; }
        public string? ServiceLogo { get; set; }
        public bool ServiceStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
