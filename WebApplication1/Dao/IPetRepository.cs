﻿using PetStore.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Dao
{
    public interface IPetRepository
    {
        IEnumerable<PetEntity> List();
        PetEntity FindById(long id);
    }
}
