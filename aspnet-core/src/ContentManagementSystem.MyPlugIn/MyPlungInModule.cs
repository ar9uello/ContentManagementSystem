using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace ContentManagementSystem.MyPlugIn;

public class MyPlungInModule : AbpModule
{
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var myService = context.ServiceProvider
            .GetRequiredService<MyService>();

        myService.Initialize();
    }
}
