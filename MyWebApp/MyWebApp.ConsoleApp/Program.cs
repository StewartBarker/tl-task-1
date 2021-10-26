using System;
using MyWebApp.DataServices;

namespace MyWebApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new GetData();
            var response = data.Get();
            if (response.Result.IsSuccessStatusCode)
            {
                var apiResponse = response.Result.Content.ReadAsStringAsync();
                Console.WriteLine(apiResponse.Result);
            }
            
            Console.ReadKey();
        }
    }
}