using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LoginManager : ILoginService
    {
        ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public Admin GetUser(string username, string password)
        {
            return _loginDal.Get(x => x.AdminName == username && x.AdminPassword==password);
        }

        public Admin GetRolesForUser(string username)
        {
            return _loginDal.Get(x => x.AdminName == username);
        }
        
    }
}
