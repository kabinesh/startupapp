using SmartSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        public SignupViewModel()
        {
            Schools = new List<SchoolModel>
            {
                new SchoolModel{Name = "Brighton School", Id=1 },

                new SchoolModel{Name = "Govt Higher Sec. School", Id=2 }
            };

            SelectedSchoolIndex = -1;
        }

        public int SelectedSchoolIndex { get; set; }

        public List<SchoolModel> Schools { get; set; }
    }
}
