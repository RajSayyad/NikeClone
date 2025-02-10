using NikeClone.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeClone.MVVM.ViewModels
{

    public class UserViewModel
    {
        public List<User> UsersList {  get; set; }
        public User CurrentUser { get; set; }
        public UserViewModel() {

            UsersList = new List<User>() {
                new User{ Id=0, Email="raj@gmail.com", Name="Raj", Password="raj12345"},
                new User{ Id=1, Email="shravan@gmail.com", Name="Shravan", Password="shravan12345"},
                new User{ Id=2, Email="jazib@gmail.com", Name="Jazib", Password="jazib12345"},
                new User{ Id=3, Email="alisha@gmail.com", Name="Alisha", Password="alisha12345"}
            };
        }

    }
}
