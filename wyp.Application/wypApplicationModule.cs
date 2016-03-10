using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace wyp
{
    [DependsOn(typeof(wypCoreModule), typeof(AbpAutoMapperModule))]
    public class wypApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
