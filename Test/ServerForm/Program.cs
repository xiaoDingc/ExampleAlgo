using HslCommunication.Enthernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerForm
{
    class Program
    {
        private static NetPushServer pushServer;
        private static Random random = new Random(); // 先定义一个随机数生成器
        static void Main(string[] args)
        {
            pushServer = new NetPushServer();
            pushServer.ServerStart(12345);
            Console.ReadKey();
            pushServer.PushString("A", random.Next(1, 1000).ToString());
            Console.WriteLine("wait 5s");
            Thread.Sleep(1000*5);
            pushServer.PushString("A", random.Next(1, 1000).ToString());
            Console.ReadKey();
        }
    }
}
