using MediatR;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.Mediator.Commands.AboutCommands;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Enums;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        IAboutManager _aboutManager;

        public CreateAboutCommandHandler(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _aboutManager.TCreateAsync(new About
            {
                AboutTitle = request.AboutTitle,
                AboutDescriptionOne = request.AboutDescriptionOne,
            });
        }
    }
}
