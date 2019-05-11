using SmartSchoolApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartSchoolApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        INavigation _navigation;
        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() => {
                    _navigation.PushAsync(new SignupPage());
                });
            }
        }
    }
}
