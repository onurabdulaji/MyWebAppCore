using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Models
{
    public class About : IEntity
    {
        public About()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutDescriptionOne { get; set; }
        public string? AboutDescriptionTwo { get; set; }
        public string? AboutDescriptionThree { get; set; }
        public string? AboutDescriptionFour { get; set; }
        public string? AboutImage { get; set; }
        public string? AboutCV { get; set; }
        public bool AboutStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
