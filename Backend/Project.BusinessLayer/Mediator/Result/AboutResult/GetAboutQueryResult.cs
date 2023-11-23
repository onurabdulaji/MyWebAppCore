using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Result.AboutResult
{
    public class GetAboutQueryResult
    {
        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutDescriptionOne { get; set; }

    }
}
