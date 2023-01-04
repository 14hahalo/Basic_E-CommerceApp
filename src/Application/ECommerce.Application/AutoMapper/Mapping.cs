using AutoMapper;

namespace ECommerce.Application.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            //Eşleştirme işlemleri gerçekleştirilecek
            //CreateMap<T,TResult>().ReverseMap(); Hangi türden veri gelirse diğerine otomatik çevir.
            //Örnek : CreateMap<T,TResult>().ReverseMap();
        }
    }
}
