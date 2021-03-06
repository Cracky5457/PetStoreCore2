﻿using PetStore.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models.Entity
{
    public class PetEntity
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public List<TagEntity> Tags { get; set; }

    }
}
