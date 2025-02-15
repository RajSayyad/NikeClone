using NikeClone.MVVM.Models;
using NikeClone.TempDBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeClone.MVVM.ViewModels
{
    public class GlobalViewModel
    {
        public User CurrentUser { get; set; }
        public UserViewModel UVMobj { get; set; } = new UserViewModel();

        public GlobalViewModel() {

            CurrentUser = new User() { Name = "Raj" };

        }
    }
}
