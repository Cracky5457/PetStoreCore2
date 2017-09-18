using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Model;
using PetStore.Models.Entity;
using PetStore.Dao;
using PetStore.Services;
using PetStore.Services.impl;
using PetStore.Models.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetStore.Controllers
{
    [Route("api/[controller]")]
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<PetDto> listPet = _petService.FindAllPet();

            if(listPet == null || !listPet.Any())
            {
                return NoContent();
       
            }

            return new ObjectResult(listPet);


        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            PetEntity entity = _petService.FindById(id);

            if (entity == null)
            {
                return NoContent();
            }

            return new ObjectResult(entity);
        }

    }
}
