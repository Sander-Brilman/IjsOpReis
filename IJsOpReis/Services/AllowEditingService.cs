using Microsoft.Extensions.Configuration;

namespace IJsOpReis.Services;

public class AllowEditingService(IConfiguration configuration)
{
    public bool IsEditingAllowed()
    {
        return configuration.GetValue<bool>("AllowEditing");
    }
}
