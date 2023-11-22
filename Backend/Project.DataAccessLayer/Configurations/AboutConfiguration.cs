﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Configurations
{
    public class AboutConfiguration : BaseConfiguration<About>
    {
        public override void Configure(EntityTypeBuilder<About> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.AboutID);
        }
    }
}
