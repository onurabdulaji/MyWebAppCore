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
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository) : base(appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
    }
}