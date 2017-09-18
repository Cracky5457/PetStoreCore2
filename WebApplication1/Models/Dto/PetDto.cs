using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models.Dto
{
    public class PetDto
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public List<TagDto> Tags { get; set; }

    }
}
