using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using SmartSchoolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartSchoolApp.Services
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<ManageGroupMessageViewModel>();
            SimpleIoc.Default.Register<AddEditGroupMessageViewModel>();
            SimpleIoc.Default.Register<GalleryViewModel>();
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

        public GalleryViewModel Gallery
        {
            get
            {
                return SimpleIoc.Default.GetInstance<GalleryViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels  
        }
    }
}
