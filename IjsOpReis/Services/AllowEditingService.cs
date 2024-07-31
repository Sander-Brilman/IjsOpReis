using Microsoft.Extensions.Configuration;

namespace IjsOpReis.Services;

public class AllowEditingService(IConfiguration configuration)
{
    public bool IsEditingAllowed()
    {
        return configuration.GetValue<bool>("AllowEditing");
    }
}
