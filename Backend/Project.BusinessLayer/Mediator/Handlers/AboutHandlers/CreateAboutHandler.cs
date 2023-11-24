using AutoMapper;
using MediatR;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.Mediator.Commands.AboutCommands;
using Project.DTOLayer.ApiDTO.AboutDtos;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutHandler : IRequestHandler<CreateAboutCommand, CreateAboutDTO>
    {
        private readonly IAboutManager _aboutManager;
        private readonly IMapper _mapper;

        public CreateAboutHandler(IMapper mapper, IAboutManager aboutManager)
        {
            _mapper = mapper;
            _aboutManager = aboutManager;
        }

        public async Task<CreateAboutDTO> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            var newAbout = _mapper.Map<About>(request);
            await _aboutManager.TCreateAsync(newAbout);
            return new CreateAboutDTO
            {
                AboutTitle = newAbout.AboutTitle,
                AboutDescriptionOne = newAbout.AboutDescriptionOne,
                AboutDescriptionTwo = newAbout.AboutDescriptionTwo,
            };
        }
    }
}
