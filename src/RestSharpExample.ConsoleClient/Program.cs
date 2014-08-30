using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestSharpExample.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("How many things do you want returned?");
                var countString = Console.ReadLine();
                int count;
                canContinue = int.TryParse(countString, out count);
                if (canContinue)
                {
                    Console.WriteLine("Waiting on the server...");
                    ProcessRequest(count, "ValuesOk");
                    ProcessRequest(count, "ValuesFound");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Finished.");
            Console.ReadLine();

        }

        private static void ProcessRequest(int count, string resource)
        {
            var client = new RestClient("http://localhost:61038/api/");
            var request = new RestRequest(resource+"?count={count}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("count", count, ParameterType.UrlSegment);

            RestResponse response = (RestResponse) client.Execute(request);
            Console.WriteLine("Status was                : {0}", response.StatusCode);
            Console.WriteLine("Status code was           : {0}", (int) response.StatusCode);
            Console.WriteLine("Response.ContentLength is : {0}", response.ContentLength);
            Console.WriteLine("Response.Content.Length is: {0}", response.Content.Length);
            Console.WriteLine();
        }
    }
}
