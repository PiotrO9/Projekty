using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Interface
{
    public interface IUserExisting
    {
        List<UserData> UsersList { get; set; }
        bool CheckUserExistence(string name, string lastName);
    }
}
