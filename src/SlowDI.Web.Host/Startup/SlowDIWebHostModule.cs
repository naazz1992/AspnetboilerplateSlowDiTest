using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SlowDI.Configuration;

namespace SlowDI.Web.Host.Startup
{
    [DependsOn(
       typeof(SlowDIWebCoreModule))]
    public class SlowDIWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SlowDIWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SlowDIWebHostModule).GetAssembly());
        }
    }
}
