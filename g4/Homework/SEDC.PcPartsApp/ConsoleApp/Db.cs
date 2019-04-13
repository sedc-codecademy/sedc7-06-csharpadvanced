using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Db
    {
        public static List<Part> Parts { get; set; }
        public static List<Module> Modules { get; set; }
        public static List<Configuration> Configurations { get; set; }
    }
}
