﻿using SmartSchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartSchoolApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupPage : ContentPage
	{
		public SignupPage ()
		{
			InitializeComponent ();

            BindingContext = new SignupViewModel();
		}
	}
}