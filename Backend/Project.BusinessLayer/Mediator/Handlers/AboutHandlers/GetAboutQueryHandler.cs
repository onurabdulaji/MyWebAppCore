using MediatR;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.Mediator.Queries.AboutQuery;
using Project.BusinessLayer.Mediator.Result.AboutResult;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
    {
        IAboutManager _aboutManager;

        public GetAboutQueryHandler(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _aboutManager.TGetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                AboutTitle = x.AboutTitle,
                AboutDescriptionOne = x.AboutDescriptionOne,
            }).ToList();
        }
    }
}


