using MediatR;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.Mediator.Queries.AboutQuery;
using Project.BusinessLayer.Mediator.Result.AboutResult;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IAboutManager _aboutManager;

        public GetAboutByIdQueryHandler(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _aboutManager.TGetByIdAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = result.AboutID,
                AboutTitle = result.AboutTitle,
                AboutDescriptionOne = result.AboutDescriptionOne,
                AboutDescriptionTwo = result.AboutDescriptionTwo,
                AboutDescriptionThree = result.AboutDescriptionThree,
                AboutDescriptionFour = result.AboutDescriptionFour,
                AboutImage = result.AboutImage,
                AboutCV = result.AboutCV,
                AboutStatus = result.AboutStatus,
            };
        }
    }
}
