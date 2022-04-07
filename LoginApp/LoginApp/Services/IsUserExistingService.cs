using LoginApp.Interface;
using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApp.Services
{
    public class IsUserExistingService : IUserExisting
    {
        public List<UserData> UsersList { get;  set; }

        public IsUserExistingService()
        {
            UsersList = new List<UserData>(){
                new UserData("Jan2115", "12345", "jan.luka@wp.pl"),
                new UserData("Adam2115", "12345", "adam.josef@wp.pl"),
                        };
        }

        public bool CheckUserExistence(string login, string password)
        {
            bool result = false;

            var query = UsersList.Select(n => n).Where(l => l.Login == login).Where(p => p.Password == password);

            if (query.Count() != 0)
                result = true;

            return result;
        }
    }
}
