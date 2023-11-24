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
    public class CreateAboutHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly IAboutManager _aboutManager;
        private readonly IMapper _mapper;

        public CreateAboutHandler(IMapper mapper, IAboutManager aboutManager)
        {
            _mapper = mapper;
            _aboutManager = aboutManager;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _aboutManager.TCreateAsync(new About
            {
                AboutTitle = request.AboutTitle,
                AboutDescriptionOne = request.AboutDescriptionOne,
                AboutDescriptionTwo = request.AboutDescriptionTwo,
                AboutStatus = request.AboutStatus,
            });
        }
    }
}
