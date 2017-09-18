using AutoMapper;
using PetStore.Dao;
using PetStore.Models.Entity;
using PetStore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Services.impl
{
    public class PetServiceImpl : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetServiceImpl(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public IEnumerable<PetDto> FindAllPet()
        {
            IEnumerable<PetEntity> entities = _petRepository.List();

            IEnumerable < PetDto > dto = Mapper.Map<IEnumerable<PetDto>>(entities);

            return dto;
        }

        public PetEntity FindById(long id)
        {
            return _petRepository.FindById(id);
        }

    }
}
