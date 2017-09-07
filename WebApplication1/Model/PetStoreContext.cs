using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using PetStore.Model.Entity;

namespace PetStore.Model
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext(DbContextOptions<PetStoreContext> options)
            : base(options)
        {
        }

        public DbSet<PetEntity> PetEntities { get; set; }
    }
}
