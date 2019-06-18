using GalaSoft.MvvmLight.Ioc;
using SmartSchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.Services
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<ManageGroupMessageViewModel>();
            SimpleIoc.Default.Register<AddEditGroupMessageViewModel>();
        }

        public LoginViewModel Login
        {
            get
            {
                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }

        public ManageGroupMessageViewModel ManageGroupMessage
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ManageGroupMessageViewModel>();
            }
        }

        public AddEditGroupMessageViewModel AddEditGroupMessage
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AddEditGroupMessageViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels  
        }
    }
}
