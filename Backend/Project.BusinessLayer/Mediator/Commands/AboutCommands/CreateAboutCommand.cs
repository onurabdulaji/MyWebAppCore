using MediatR;
using Project.DTOLayer.ApiDTO.AboutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Commands.AboutCommands
{
    public class CreateAboutCommand : IRequest
    {
        public string AboutTitle { get; set; }
        public string AboutDescriptionOne { get; set; }
        public string AboutDescriptionTwo { get; set; }
        public bool AboutStatus { get; set; }
    }
}
