using Project.DataAccessLayer.Context;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Repositories.Concretes
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(MyContext db) : base(db)
        {
        }
    }
}
