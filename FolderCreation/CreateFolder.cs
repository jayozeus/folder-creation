using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FolderCreation
{
    class CreateFolder
    {
        readonly MyConfig _myconfig;
        public CreateFolder(MyConfig myConfig)
        {
            _myconfig = myConfig;
        }

        public Task folderCreate()
        {
            Guid newId = Guid.NewGuid();
            for (var i=0;i< _myconfig.folderCountLimit; i++)
            {                
                var dir = Path.Join(_myconfig.rootFolder,$"{newId}_{i}");

                Directory.CreateDirectory(dir);
                if(i % 1000 == 0)
                {
                    Console.WriteLine($"doneCont  -> {i}... folder created..");
                }
                
            }

            return Task.CompletedTask;
        }
    }
}
