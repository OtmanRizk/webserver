using System.Net;
using System.Net.Sockets;
using System.Text;
using webserver.Models;

TcpListener myListener;
int port = 5050;
IPAddress localAddr = IPAddress.Parse("127.0.0.1");

//web server path
string WebServerPath = @"client";


myListener = new TcpListener(localAddr, port);
myListener.Start();
Console.WriteLine($"Web Server Running on {localAddr.ToString()} on port {port}... Press ^C to Stop...");
Thread th = new Thread(new ThreadStart(StartListen));
th.Start();

void StartListen()
{
        while (true)
        {
                try
                {
                        TcpClient client = myListener.AcceptTcpClient();
                        NetworkStream stream = client.GetStream();

                        byte[] readBuffer = new byte[1024];
                        StringBuilder completeMesssage = new StringBuilder();
                        int numberBytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                        completeMesssage.Append(Encoding.UTF8.GetString(readBuffer, 0, numberBytesRead));

                        getRequest getRequest = new getRequest();
                        getRequest.ParseRequest(completeMesssage.ToString());
                        

                        postResponse postResponse = new("HTTP/1.1",200,"OK");
                        postResponse.sendMessage(stream);

                        Console.WriteLine($"Message received: {completeMesssage}");
                        client.Close();
                }
                catch (SocketException)
                {
                        Console.WriteLine("SocketException");

                }
                catch (System.Exception err)
                {
                        Console.WriteLine($"Message: {err.Message}\n StackTrace: {err.StackTrace}");

                }

        }
}

void handleRequest()
{

}