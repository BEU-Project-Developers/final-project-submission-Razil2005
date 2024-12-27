using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WInformRazil.DataAccess;

namespace WInformRazil.Services
{
    public static class LoginService
    {
        public static bool Authenticate(string login, string password)
        {
            using (var context = new LibraryDbContext())
            {

                var admin = context.Admins.FirstOrDefault(a => a.Login == login && a.Password == password);

                return admin != null;
            }
        }
    }
}
