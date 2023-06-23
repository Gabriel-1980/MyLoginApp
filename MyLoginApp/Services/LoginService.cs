using MyLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginApp.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserInfo> ILoginRepository.Login(string username, string password)
        {     
            try
            {
                if(Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new UserInfo();
                    var client = new HttpClient();
                    //string url =
                }
            }
        }
    }
}
