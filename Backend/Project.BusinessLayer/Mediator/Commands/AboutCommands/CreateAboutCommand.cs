using MediatR;
using Project.DTOLayer.ApiDTO.AboutDTO;

namespace Project.BusinessLayer.Mediator.Commands.AboutCommands
{
    public class CreateAboutCommand(string AboutTitle, string AboutDescriptionOne, string AboutDescriptionTwo, bool AboutStatus) : IRequest<AboutDetails>
    {
        public string AboutTitle { get; set; } = AboutTitle;
        public string AboutDescriptionOne { get; set; } = AboutDescriptionOne;
        public string AboutDescriptionTwo { get; set; } = AboutDescriptionTwo;
        public bool AboutStatus { get; set; } = AboutStatus;
    }
}