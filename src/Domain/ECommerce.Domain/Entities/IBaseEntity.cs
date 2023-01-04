using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities
{
    public interface IBaseEntity
    {
        DateTime CreateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        DateTime? UpdateDate { get; set; }
        Status Status { get; set; }
    }
}