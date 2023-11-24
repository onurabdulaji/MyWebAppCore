using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOLayer.ApiDTO.AboutDTO
{
    public class AboutDetails
    {
        public int AboutID { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescriptionOne { get; set; }
        public string AboutDescriptionTwo { get; set; }
        public string AboutDescriptionThree { get; set; }
        public string AboutDescriptionFour { get; set; }
        public string AboutImage { get; set; }
        public string AboutCV { get; set; }
        public bool AboutStatus { get; set; }
    }
}
