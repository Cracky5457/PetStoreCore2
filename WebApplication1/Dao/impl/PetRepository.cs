using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetStore.Model.Entity;
using PetStore.Model;

namespace PetStore.Dao.impl
{
    public class PetRepository : IPetRepository
    {
        private readonly PetStoreContext _dbContext;

        public PetRepository(PetStoreContext dbContext)
        {
            _dbContext = dbContext;

            if (_dbContext.PetEntities.Count() == 0)
            {
                _dbContext.PetEntities.Add(new PetEntity { Name = "Nala" });
                _dbContext.PetEntities.Add(new PetEntity { Name = "BBL" });

                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<PetEntity> List()
        {
            return _dbContext.PetEntities;
        }

        public PetEntity FindById(long id)
        {
            return _dbContext.PetEntities.FirstOrDefault(t => t.Id == id);
        }
    }
}
