﻿using System;
using CommandLine;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeFilesDate
{
    class SomeOptions
    {
        [Option('p', "path", Default = ".")]
        public string Path { get; set; }

        [Option('f', "filter", Default = "*")]
        public string Filter { get; set; }

        [Option('d', "date", Default = null)]
        public string Date { get; set; }
    }
}
