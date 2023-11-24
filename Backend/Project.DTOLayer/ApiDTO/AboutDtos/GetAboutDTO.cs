using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOLayer.ApiDTO.AboutDtos
{
    public class GetAboutDto
    {
        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutDescriptionOne { get; set; }
    }
}
