using System;
using System.Collections.Generic;

namespace labs
{
    class Proxy
    {
        static void Main(string[] args)
        {
            new Lab13Proxy().Run();
        }
    }
    public interface Lab
    {
        void Run();
    }
    class Lab13Proxy : Lab
    {
        public void Run()
        {
            // Proxy
            // Utwórz klasę HttpLoggerProxy, która wyświetli na ekranie jaki Request jest wysyłany.
            // Oraz jaki Response zostaje zwrócony.
            // Na e.wsei wrzucamy tylko klasę HttpLoggerProxy

            // Na konsoli powinno się wypisać:

            // Request GET - www.google.com
            // Response - Mock data from the web

            // Request PUT - www.gmail.com
            // Response - Mock data from the web

            BasicHttpClient client = new BasicHttpClient();
            HttpLoggerProxy proxy = new HttpLoggerProxy(client);
            proxy.MakeRequest("www.google.com", HttpMethod.GET);
            proxy.MakeRequest("www.gmail.com", HttpMethod.PUT);
        }
    }



    class BasicHttpClient : IHttpClient
    {
        public String MakeRequest(String url, HttpMethod method)
        {
            return "Mock data from the web";
        }
    }

    public interface IHttpClient
    {
        String MakeRequest(String url, HttpMethod method);
    }

    public enum HttpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class HttpLoggerProxy : IHttpClient
    {
        private readonly BasicHttpClient Client; 

        public HttpLoggerProxy(BasicHttpClient client)
        {
            this.Client = client;
        }

        public string MakeRequest(string url, HttpMethod method)
        {
            Console.WriteLine($"Request: {method.ToString()} - {url}");
            var response = Client.MakeRequest(url, method);
            Console.WriteLine($"Response {response}");
            return response;
        }
    }
}