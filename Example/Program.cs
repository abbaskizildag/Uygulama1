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

        //�lk ad�m startup k�sm�ndan controller'a kullanma mapleme yapt�k.
        //ikinci olarak controller ekledik. bu miras ald�. ve metot ekledik.
        //���nc� ad�m modele ekledik. 5 propert'ili elemanlar�m�z� ekledik
        //d�rd�nc� ad�mda fakedata'y� olu�turuyoruz. getuser isimli bir fakedata metodumu yazd�k
        //
    }
}
