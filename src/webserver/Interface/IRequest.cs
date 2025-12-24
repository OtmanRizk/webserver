using System;

namespace webserver.Interface;

public interface IRequest
{
   /*
   essage received: GET / HTTP/1.1
Host: 127.0.0.1:5050
Sec-Fetch-Dest: document
User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/18.6 Safari/605.1.15
Upgrade-Insecure-Requests: 1
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*;q=0.8
Sec-Fetch-Site: none
Sec-Fetch-Mode: navigate
Accept-Language: en-US,en;q=0.9
Priority: u=0, i
Accept-Encoding: gzip, deflate
Connection: keep-alive*/

   public string messageReceived {get;set;}   
   public string host {get;set;}

   public string secFetchDest {get;set;}
   public string userAgent {get;set;}
   public string upgradeInsecure {get;set;}
   public string accept {get;set;}

   public void ParseRequest(string message);

}
