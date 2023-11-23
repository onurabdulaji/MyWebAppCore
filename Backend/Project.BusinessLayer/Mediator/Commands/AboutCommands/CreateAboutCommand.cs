using MediatR;
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

    }
}
