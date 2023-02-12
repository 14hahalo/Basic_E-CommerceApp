using AutoMapper;
using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            //Eşleştirme işlemleri gerçekleştirilecek
            //CreateMap<T,TResult>().ReverseMap(); Hangi türden veri gelirse diğerine otomatik çevir.
            //Örnek : CreateMap<T,TResult>().ReverseMap();
            CreateMap<Employee, AddManagerDTO>().ReverseMap();
            CreateMap<Employee, ListOfManagersVM>().ReverseMap();
            CreateMap<UpdateManagerVM, UpdateManagerDTO>().ReverseMap();
            CreateMap<UpdateManagerDTO, Employee>().ReverseMap();
        }
    }
}
