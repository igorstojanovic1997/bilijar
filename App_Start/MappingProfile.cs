using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using bilijar.Dtos;
using bilijar.Models;
using bilijar.ViewModels;

namespace bilijar.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Reservation, ReservationDto>();
            Mapper.CreateMap<ReservationDto, Reservation>();
            Mapper.CreateMap<Reservation, NewReservationViewModel>().ReverseMap();
        }
    }
}