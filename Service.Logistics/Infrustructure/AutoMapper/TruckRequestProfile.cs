using AutoMapper;
using Service.Logistics.Models;
using System;

namespace Service.Logistics.Infrustructure.AutoMapper
{
    public class TruckRequestProfile : Profile
    {
        public TruckRequestProfile()
        {
            this.CreateMap<TruckRequest, TruckModel>();
            this.CreateMap<TruckDataModel, TruckResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ObjectID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Applicant))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.FoodItems, opt => opt.MapFrom(src => src.FoodItems));
        }
    }
}
