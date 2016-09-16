using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace sebm
{
    class serverinfo
    {

        public string getsebmversion()
        {

                tools.downlaodFile("http://s.thatseliyt.de/", "sebmversion.txt", "sebmversion.txt");
                var version = File.ReadAllLines("sebmversion.txt");
                File.Delete("sebmversion.txt");

                return version[0];
            
        }

        public string[] getLargeBlockDef()
        {
            tools.downlaodFile("http://s.thatseliyt.de/", "largeBlocks.txt", "largeBlocks.txt");
            var v = File.ReadAllLines("largeBlocks.txt");
            File.Delete("largeBlocks.txt");
            return v;
        }

        public string[] getSmallBlockDef()
        {
            tools.downlaodFile("http://s.thatseliyt.de/", "smallBlocks.txt", "smallBlocks.txt");
            var v = File.ReadAllLines("smallBlocks.txt");
            File.Delete("smallBlocks.txt");
            return v;
        }

    }
}
