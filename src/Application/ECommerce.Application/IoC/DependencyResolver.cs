using Autofac;
using AutoMapper;
using ECommerce.Application.AutoMapper;
using ECommerce.Application.Services.AdminService;
using ECommerce.Domain.Repositories;
using ECommerce.Infrastructure.Repositories;

namespace ECommerce.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //IoC --> Yani interface çağırdığım zaman bana onun Concrete yapısını getirmesi gerektiğini söylüyorduk.
            builder.RegisterType<EmployeeRepo>().As<IEmployeeRepo>().InstancePerLifetimeScope();
            builder.RegisterType<AdminService>().As<IAdminService>().InstancePerLifetimeScope();
            // ÖRNEK :
            // builder.RegisterType<BaseRepo>().As<IBaseRepo>().InstancePerLisfeTimeScope();

            //program.cs tarafında yapacağım eklemeleri buradan yapabilirimç
            //Örnek olarak automapper eklenmesini buradan yapabilirim.

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                //Mapping dosyamızıda buraya ekliyoruz gidip startup'ta eklemek zorunda kalmayalım zaten burasının görevi oraya sağlamak olacak.
                cfg.AddProfile<Mapping>();
            }
                    )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
