using System;
using System.Net.Sockets;
using System.Text;
using webserver.Interface;

namespace webserver.Models;

public class postResponse : IResponse
{

   private string _messageResponse;
   public postResponse(string protocolVersion,int statusCode, string statusMessage)
   {
      _messageResponse = $"HTTP/1.1 {statusCode} {statusMessage}\r\n" +
                $"Connection: Keep-Alive\r\n" +
                $"Date: {DateTime.UtcNow.ToString()}\r\n" +
                $"Server: MacOs PC \r\n" +
                $"Content-Encoding: \r\n" +
                "X-Content-Type-Options: nosniff"+
                $"Content-Type: application/signed-exchange;v=b3\r\n\r\n";

   }   
   
   public string messageResponse { get; set; }
   public string date { get; set; }
   public string server { get; set; }
   public string lastModified { get; set; }
   public string eTag { get; set; }
   public string acceptRanges { get; set; }
   public string contentLength { get; set; }
   public string contentType { get; set; }

   public void sendMessage(object? Sender)
   {


      Console.WriteLine(_messageResponse);
      byte[] buffer = Encoding.UTF8.GetBytes(_messageResponse);
      ((NetworkStream)Sender).Write(buffer,0,buffer.Length);
   }

}
