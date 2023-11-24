using MediatR;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.Mediator.Queries.AboutQuery;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.DTOLayer.ApiDTO.AboutDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Handlers.AboutHandlers
{
    public class GetAboutListHandler : IRequestHandler<GetAboutQuery, List<AboutDetails>>
    {
        private readonly IAboutManager _aboutManager;

        public GetAboutListHandler(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        public async Task<List<AboutDetails>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _aboutManager.TGetAllAsync();
            return values.Select(x => new AboutDetails
            {
                AboutID = x.AboutID,
                AboutTitle = x.AboutTitle,
                AboutDescriptionOne = x.AboutDescriptionOne,
                AboutDescriptionTwo = x.AboutDescriptionTwo,
                AboutDescriptionThree = x.AboutDescriptionThree,
                AboutDescriptionFour = x.AboutDescriptionFour,
                AboutImage = x.AboutImage,
                AboutCV = x.AboutCV,
                AboutStatus = x.AboutStatus,
            }).ToList();
        }
    }
}
