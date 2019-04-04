using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Exceed.Authorization;

namespace Exceed
{
    [DependsOn(
        typeof(ExceedCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExceedApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExceedAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExceedApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
