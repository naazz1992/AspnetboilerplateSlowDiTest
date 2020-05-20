using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SlowDI.Authorization;

namespace SlowDI
{
    [DependsOn(
        typeof(SlowDICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SlowDIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SlowDIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SlowDIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
