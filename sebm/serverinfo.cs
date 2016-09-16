using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace sebm
{
    class serverinfo
    {

        public string getsebmversion()
        {

            tools.downlaodFile("http://s.thatseliyt.de/", "semlversion.txt", "semlversion.txt");
            var version = File.ReadAllLines("semlversion.txt");
            File.Delete("semlversion.txt");

            return version[0];
        }

        public string[] getLargeBlockDef()
        {
            tools.downlaodFile("http://s.thatseliyt.de/", "largeBlocks.txt", "largeBlocks.txt");
            return File.ReadAllLines("largeBlocks.txt");
            File.Delete("largeBlocks.txt");
        }

        public string[] getSmallBlockDef()
        {
            tools.downlaodFile("http://s.thatseliyt.de/", "smallBlocks.txt", "smallBlocks.txt");
            return File.ReadAllLines("smallBlocks.txt");
            File.Delete("smallBlocks.txt");
        }

    }
}
