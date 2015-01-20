using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathViewer; 

namespace PathViewerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = EnvironmentData.GetEnvironmentFromRegistry("PATH");
            Console.WriteLine("Path = {0}", result);
        }
    }
}
