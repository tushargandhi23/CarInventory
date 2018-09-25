using AutoMapper;
using CarInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInventory.App_Start
{
    public static class AutoMapperConfiguration
    {
        /// <summary>
        /// Function to configure model-entity mapping
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserModel, tbl_users>()
                    .ForMember(dest => dest.created_date, opt => opt.MapFrom(src => src.CreatedOn));
                cfg.CreateMap<tbl_users, UserModel>()
                    .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.created_date)); ;
            });
        }
    }
}