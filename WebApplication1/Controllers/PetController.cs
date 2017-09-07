using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Model;
using PetStore.Model.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetStore.Controllers
{
    [Route("api/[controller]")]
    public class PetController : Controller
    {
        private readonly PetStoreContext _context;

        public PetController(PetStoreContext context)
        {
            _context = context;

            if (_context.PetEntities.Count() == 0)
            {
                _context.PetEntities.Add(new PetEntity { Name = "Nala" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<PetEntity> GetAll()
        {
            return _context.PetEntities.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = _context.PetEntities.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

    }
}
