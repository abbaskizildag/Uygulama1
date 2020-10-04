using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //Ýlk adým startup kýsmýndan controller'a kullanma mapleme yaptýk.
        //ikinci olarak controller ekledik. bu miras aldý. ve metot ekledik.
        //üçüncü adým modele ekledik. 5 propert'ili elemanlarýmýzý ekledik
        //dördüncü adýmda fakedata'yý oluþturuyoruz. getuser isimli bir fakedata metodumu yazdýk
        //
    }
}
