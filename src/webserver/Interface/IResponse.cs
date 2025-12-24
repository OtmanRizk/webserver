using System;

namespace webserver.Interface;

public interface IResponse
{
   /*HTTP/1.1 200 OK
Date: Sat, 09 Oct 2010 14:28:02 GMT
Server: Apache
Last-Modified: Tue, 01 Dec 2009 20:18:22 GMT
ETag: "51142bc1-7449-479b075b2891b"
Accept-Ranges: bytes
Content-Length: 29769
Content-Type: text/html

<!DOCTYPE html>… (here come the 29769 bytes of the requested web page)*/
   public string messageResponse { get; set; }
   public string date { get; set; }
   public string server { get; set; }
   public string lastModified { get; set; }
   public string eTag { get; set; }
   public string acceptRanges { get; set; }
   public string contentLength { get; set; }
   public string contentType { get; set; }

   public void sendMessage(object? Sender);




}
