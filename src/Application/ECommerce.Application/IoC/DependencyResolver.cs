using Autofac;

namespace ECommerce.Application.IoC
{
    public class DependencyResolver:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //IoC --> Yani interface çağırdığım zaman bana onun Concrete yapısını getirmesi gerektiğini söylüyorduk.

            // ÖRNEK :
            // builder.RegisterType<BaseRepo>().As<IBaseRepo>().InstancePerLisfeTimeScope();

            //program.cs tarafında yapacağım eklemeleri buradan yapabilirimç
            //Örnek olarak automapper eklenmesini buradan yapabilirim.

            base.Load(builder);

        }
    }
}
