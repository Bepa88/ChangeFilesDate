using System;
using System.Collections.Generic;
using System.IO;
using CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeFilesDate
{
    class ChangeFilesDate
    {
        static void Main(string[] args)
        {
            var options = new SomeOptions();
            var v = Parser.Default.ParseArguments<SomeOptions>(args)
    .WithParsed<SomeOptions>(opts => options = opts);

            DirectoryInfo di = new DirectoryInfo(options.Path);
            FileInfo[] images = di.GetFiles(options.Filter);

            if (options.Date == null)
            {
                options.Date = DateTime.Now.ToString();
            }

            foreach (var image in images)
            {
                image.CreationTime = Convert.ToDateTime(options.Date);
                image.LastWriteTime = Convert.ToDateTime(options.Date);
            }
        }
    }
}
