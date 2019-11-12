using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Program
    {
        static byte[] buffer = new byte[1024];
        static  Socket socket;
        static void Main(string[] args)
        {
            try
            {
                //①创建一个Socket
               socket  = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
 
                //②连接到指定服务器的指定端口
                socket.Connect("127.0.0.1", 7788); //localhost代表本机
 
                WriteLine("client:connect to server success!", ConsoleColor.White);
 
                //③实现异步接受消息的方法 客户端不断监听消息
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
                while (true)
                {
                    var message = Console.ReadLine();
                    SendMessage(message);
                }
            }
            catch (Exception ex)
            {
                WriteLine("client:error " + ex.Message, ConsoleColor.Red);
            }

        }
        public static  void SendMessage(string message)
        {
               //④接受用户输入，将消息发送给服务器端
               // var message = Console.ReadLine();
                var outputBuffer = Encoding.UTF8.GetBytes(message);
                socket.BeginSend(outputBuffer, 0, outputBuffer.Length, SocketFlags.None, null, null);
        }
       
        #region 接收信息
        /// <summary>
        /// 接收信息
        /// </summary>
        /// <param name="ar"></param>
        public static void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                var socketRec = ar.AsyncState as Socket;
                
                var length = socketRec.EndReceive(ar);
                //读取出来消息内容
                var message = Encoding.ASCII.GetString(buffer, 0, length);
 
                if (message.Contains("OK"))
                {
                    WriteLine("很好,OK",ConsoleColor.Red);
                }
                else if (message.Contains("xx"))
                {
                    WriteLine("ni cai shi xx",ConsoleColor.Blue);
                }
 
                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息了）
                socketRec.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socketRec);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message, ConsoleColor.Red);
            }
        }
        #endregion
 
        #region 扩展方法
        public static void WriteLine(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("[{0}] {1}", DateTime.Now.ToString("MM-dd HH:mm:ss"), str);
        }
        #endregion
    }
}
