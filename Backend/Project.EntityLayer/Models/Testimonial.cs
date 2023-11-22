using Project.EntityLayer.Enums;
using Project.EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Models
{
    public class Testimonial : IEntity
    {
        public Testimonial()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int TestimonialID { get; set; }
        public string? TestimonialTitle { get; set; }
        public string? TestimonialContent { get; set; }
        public string? TestimonialImage { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
