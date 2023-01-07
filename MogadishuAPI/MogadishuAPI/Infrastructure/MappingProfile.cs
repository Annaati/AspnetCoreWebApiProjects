using AutoMapper;
using MogadishuAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MogadishuAPI.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, option => option.MapFrom(src => src.Rate / 100.0m))
                .ForMember(dest => dest.Self, opt => opt.MapFrom(src => Link.To(
                      nameof(Controllers.RoomsController.GetRoomById), new { roomId = src.Id })));
        }
    }
}
