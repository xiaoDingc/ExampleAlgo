using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLife.Log;
using XCode.Membership;

namespace LifeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //XTrace.UseConsole();

            //var user=new UserX()
            //{
            //     Name = "ding",
            //     Enable = true
            //};
            //user.Insert();
            //XTrace.WriteLine($"用户id{user.ID}");

            var user=UserX.Find(UserX._.Name=="ding");
            Console.WriteLine(user.Name);
            Console.ReadKey();

        }
    }
}
