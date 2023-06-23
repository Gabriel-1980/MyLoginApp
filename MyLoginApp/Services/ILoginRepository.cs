﻿using MyLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginApp.Services
{
    internal interface ILoginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
