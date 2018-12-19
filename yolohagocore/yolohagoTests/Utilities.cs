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

        internal static Task CreateValidTask(string taskName = "Do this, get paid.", string description = "To get paid, this is what you have to do.",
                                                string duration = "00:00:15", string priority = "High", string type = "Absolute")
        {
            Task task = new Task()
            {
                TaskName = taskName,
                Description = description,
                Duration = duration,
                Priority = priority,
                Type = type
            };
            return task;
        }

        internal static Task CreateValidTask2(string taskName = "Do this thing, get paid.", string description = "To get paid, this is what you MUST to do.",
                                                string duration = "00:00:25", string priority = "Low", string type = "Recurrent")
        {
            Task task = new Task()
            {
                TaskName = taskName,
                Description = description,
                Duration = duration,
                Priority = priority,
                Type = type
            };
            return task;
        }
    }
}



