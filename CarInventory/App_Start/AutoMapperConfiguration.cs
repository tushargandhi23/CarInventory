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
                    .ForMember(dest => dest.created_date, opt => opt.MapFrom(src => src.CreatedOn))
                    .ForMember(dest => dest.user_name, opt => opt.MapFrom(src => src.UserName));
                cfg.CreateMap<tbl_users, UserModel>()
                    .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.created_date))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.user_name));
                cfg.CreateMap<tbl_cars, CarModel>()
                    .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.created_date))
                    .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.created_by))
                    .ForMember(dest => dest.isNew, opt => opt.MapFrom(src => src.is_new));
                cfg.CreateMap<CarModel, tbl_cars>()
                    .ForMember(dest => dest.created_date, opt => opt.MapFrom(src => src.CreatedOn))
                    .ForMember(dest => dest.created_by, opt => opt.MapFrom(src => src.CreatedBy))
                    .ForMember(dest => dest.is_new, opt => opt.MapFrom(src => src.isNew));
            });
        }
    }
}