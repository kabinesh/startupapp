using Acr.UserDialogs;
using SmartSchoolApp.Interface;
using SmartSchoolApp.Models;
using SmartSchoolApp.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        IRestApi _restApi;

        public User LoginUser { get; set; }

        public LoginViewModel()
        {
            _restApi = App.RestApiService;

            LoginUser = new User();
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Login();
                });
            }
        }

        private async Task Login()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Please wait....");

                var loginResponse = await _restApi.Login(LoginUser);

                if(loginResponse.Status=="failed")
                {
                    HideLoading();
                    UserDialogs.Instance.Toast(loginResponse.Message);
                }
                else
                {
                    App.Current.MainPage = new MainPage();
                }
            }
            catch(Exception ex)
            {
            }

            finally
            {
                HideLoading();
            }
        }

        private void HideLoading()
        {
            UserDialogs.Instance.HideLoading();
        }
    }
}
