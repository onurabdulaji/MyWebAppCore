﻿using MediatR;
using Project.BusinessLayer.Mediator.Result.AboutResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Mediator.Queries.AboutQuery
{
    public class GetAboutQuery : IRequest<List<GetAboutQueryResult>>
    {
    }
}
