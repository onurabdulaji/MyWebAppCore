using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Configurations
{
    public class WorkConfiguration : BaseConfiguration<Work>
    {
        public override void Configure(EntityTypeBuilder<Work> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.WorkID);
        }
    }
}
