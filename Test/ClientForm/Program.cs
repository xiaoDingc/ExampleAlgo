using HslCommunication;
using HslCommunication.Enthernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    class Program
    {
        private static NetPushClient pushClient;
        static void Main(string[] args)
        {
            pushClient = new NetPushClient("127.0.0.1", 12345, "A");
            OperateResult create = pushClient.CreatePush((NetPushClient, y) =>
            {
                Console.WriteLine(y);
            });
            Console.ReadKey();
        }

    }
}
