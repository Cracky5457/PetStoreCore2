using AutoMapper;
using PetStore.Models.Entity;
using PetStore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Configuration
{
    public static class ConfigurationAutoMapper
    {
        public static void configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<TagEntity, TagDto>();
                cfg.CreateMap<PetEntity, PetDto>();
            });
        }
    }
}
