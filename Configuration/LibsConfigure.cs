using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_HW2.Models;

namespace EntityFrameWork_Hw2.Configuration;

public class LibsConfigure : IEntityTypeConfiguration<Libs>
{
    public void Configure(EntityTypeBuilder<Libs> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);


        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

    }
}