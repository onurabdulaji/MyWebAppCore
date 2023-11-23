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
    public class AboutManager : BaseManager<About>, IAboutManager
    {
        IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository) : base(aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
    }
}
