using Lab21.Models;

namespace Lab21.Services
{
    public class HomeFacade : IHomeFacade
    {

        public RegisterDetailsViewModel Map(RegisterViewModel model)
        {
            var viewModel = new RegisterDetailsViewModel();
            viewModel.FirstName = model.FirstName;
            viewModel.LastName = model.LastName;
            viewModel.PhoneNumber = model.PhoneNumber;
            viewModel.EmailAddress = model.EmailAddress;
            viewModel.Password = model.Password;
            return viewModel;
        }

    }
}
