using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Model;
using PetStore.Model.Entity;
using PetStore.Dao;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetStore.Controllers
{
    [Route("api/[controller]")]
    public class PetController : Controller
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpGet]
        public IEnumerable<PetEntity> GetAll()
        {
            return _petRepository.List();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            PetEntity entity = _petRepository.FindById(id);

            if (entity == null)
            {
                return NotFound();
            }

            return new ObjectResult(entity);
        }

    }
}
