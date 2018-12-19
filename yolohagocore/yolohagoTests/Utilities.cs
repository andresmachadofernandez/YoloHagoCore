using System;
using System.Collections.Generic;
using System.Text;
using yolohago.Models;

namespace yolohagoTests
{
    class Utilities
    {
        public static User CreateValidUser1(string username = "Username", string name = "Name", string lastname = "Lastname",
                                            string password = "Password", string email = "email@mock.com")
        {
            User user = new User()
            {
                Username = username,
                Name = name,
                Lastname = lastname,
                Password = password,
                Email = email
            };
            return user;
        }
        public static User CreateValidUser2(string username = "Username2", string name = "Name2", string lastname = "Lastname2",
                                            string password = "Password2", string email = "email2@mock.com")
        {
            User user = new User()
            {
                Username = username,
                Name = name,
                Lastname = lastname,
                Password = password,
                Email = email
            };
            return user;
        }

    }
}
