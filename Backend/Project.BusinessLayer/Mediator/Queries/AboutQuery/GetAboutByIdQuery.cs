using MediatR;
using Project.BusinessLayer.Mediator.Result.AboutResult;
using Project.DTOLayer.ApiDTO.AboutDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Queries.AboutQuery
{
    public class GetAboutByIdQuery : IRequest<AboutDetails>
    {
        public int Id { get; set; }

    }
}
