using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCkata2
{
    public class Program
    {
        public static System.Collections.Generic.List<MVCkata2.Models.User> userList = new List<Models.User>();
        public static void Main(string[] args)
        {
            var editUser = new Models.User();
            editUser.Id = 1;
            editUser.FirstName = "Vash";
            editUser.LastName = "TheStampede";
            editUser.FavoriteCartoon = "X/1999";
            userList.Add(editUser);

            var editUserB = new Models.User();
            editUserB.Id = 2;
            editUserB.FirstName = "Kamui";
            editUserB.LastName = "Shiro";
            editUserB.FavoriteCartoon = "Trigun";
            userList.Add(editUserB);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
