using System;
using webserver.Interface;

namespace webserver.Models;

public class getRequest : IRequest
{
   private string _messageReceived;
   private string _host;
   private string _secFetchDest;
   private string _userAgent;
   private string _upgradeInsecure;
   private string _accept;

   public string messageReceived
   {
      get
      {
         return _messageReceived;
      }
      set
      {
         _messageReceived = value;
      }
   }
   public string host
   {
      get
      {
         return _host;
      }
      set
      {
         _host = value;
      }
   }
   public string secFetchDest
   {
      get
      {
         return _secFetchDest;
      }
      set
      {
         _secFetchDest = value;
      }
   }
   public string userAgent
   {
      get
      {
         return _userAgent;
      }
      set
      {
         _userAgent = value;
      }
   }
   public string upgradeInsecure
   {
      get
      {
         return _upgradeInsecure;
      }
      set
      {
         _upgradeInsecure = value;
      }
   }
   public string accept
   {
      get
      {
         return _accept;
      }
      set
      {
         _accept = value;
      }
   }
   public void ParseRequest(string message)
   {

      string[] headers = message.Split(": ");
      if (headers != null && headers.Length > 0)
      {
         _messageReceived = headers[0];
         _host = headers[1];

      }
      else
      {
         throw new Exception("Message not parsable");
      }
   }



}
