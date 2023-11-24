using MediatR;
using Project.DTOLayer.ApiDTO.AboutDTO;

namespace Project.BusinessLayer.Mediator.Commands.AboutCommands
{
    public class CreateAboutCommand : IRequest<AboutDetails>
    {
        public string AboutTitle { get; set; }
        public string AboutDescriptionOne { get; set; }
        public string AboutDescriptionTwo { get; set; }
        public bool AboutStatus { get; set; }

        public CreateAboutCommand(string AboutTitle, string AboutDescriptionOne, string AboutDescriptionTwo, bool AboutStatus)
        {
            this.AboutTitle = AboutTitle;
            this.AboutDescriptionOne = AboutDescriptionOne;
            this.AboutDescriptionTwo = AboutDescriptionTwo;
            this.AboutStatus = AboutStatus;
        }
    }
}