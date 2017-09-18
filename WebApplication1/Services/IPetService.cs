using PetStore.Models.Entity;
using PetStore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Services
{
    public interface IPetService
    {
        IEnumerable<PetDto> FindAllPet();

        PetEntity FindById(long id);
    }
}
