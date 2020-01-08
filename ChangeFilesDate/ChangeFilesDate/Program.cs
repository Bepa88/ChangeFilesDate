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
            //string path = @"C:\Videos";
            //DateTime newDate = new DateTime(2019, 09, 27);

            var options = new SomeOptions();
            var v = Parser.Default.ParseArguments<SomeOptions>(args)
    .WithParsed<SomeOptions>(opts => options = opts);

            DirectoryInfo di = new DirectoryInfo(options.Path);
            FileInfo[] images = di.GetFiles(options.Filter);
            foreach (var image in images)
            {
                if (options.Date == "not specified")
                {
                    options.Date = DateTime.Now.ToString();
                }

                image.CreationTime = Convert.ToDateTime(options.Date);
            }
        }
    }
}
