using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace FolderCreation
{
    class Program
    {
        readonly MyConfig _myconfig;

        public Program()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())

                .AddEnvironmentVariables();

            var configuration = builder.Build();

            var myconfig = new MyConfig();
            configuration.GetSection("myconfig").Bind(myconfig);
            _myconfig = myconfig;
        }
        static async Task Main(string[] args)
        {
            try
            {
                var program = new Program();

                var doc = new CreateFolder(
                    myConfig: program._myconfig
                    );

                await doc.folderCreate();

                Console.WriteLine("Script Completed!!!");

                var waitInLoop = true;
                while(waitInLoop)
                {
                    Console.WriteLine("Waiting in loop");
                    Task.Delay(TimeSpan.FromMinutes(5)).Wait();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed With Exception");
                Console.Error.Write(ex.ToString());

                Console.ReadKey();
            }
        }
    }
}
