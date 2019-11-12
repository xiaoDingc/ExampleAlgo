using System;
using NewLife.Log;
using XCode.Membership;

namespace newLife
{
    class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole();

            var user=new UserX()
            {
                 Name = "ding",
                 Enable = true
            };
            user.Insert();
            XTrace.WriteLine($"用户id{user.ID}");

            //var user2=UserX.Find(UserX._.Name=="ding");

            //user2.Logins++;
            //user2.LastLogin=DateTime.Now;
            //user2.Update();

            Console.ReadKey();
        }
    }
}
