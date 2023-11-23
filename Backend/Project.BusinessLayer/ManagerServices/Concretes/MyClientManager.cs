using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.ManagerServices.Concretes
{
    public class MyClientManager : BaseManager<MyClient>, IMyClientManager
    {
        IMyClientRepository _myClientRepository;

        public MyClientManager(IMyClientRepository myClientRepository) : base(myClientRepository)
        {
            _myClientRepository = myClientRepository;
        }
    }
}
