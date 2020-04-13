using Lab21.Models;

namespace Lab21.Services
{
    public interface IHomeFacade
    {
        RegisterDetailsViewModel Map(RegisterViewModel model);
    }
}
