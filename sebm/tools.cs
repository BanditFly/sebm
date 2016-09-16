using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace sebm
{
    class tools
    {

        public static void copyDirectory(string strSource, string strDestination)
        {
            if (!Directory.Exists(strDestination))
            {
                Directory.CreateDirectory(strDestination);
            }
            DirectoryInfo info = new DirectoryInfo(strSource);
            FileInfo[] files = info.GetFiles();
            foreach (FileInfo info2 in files)
            {
                info2.CopyTo(Path.Combine(strDestination, info2.Name), true);
            }
            DirectoryInfo[] directories = info.GetDirectories();
            foreach (DirectoryInfo info3 in directories)
            {
                copyDirectory(Path.Combine(strSource, info3.Name), Path.Combine(strDestination, info3.Name));
            }
        }
        public static void downlaodFile(string url, string file, string filename)
        {
            string str = url;
            string address = null;
            WebClient client = new WebClient();
            address = str + file;
            client.DownloadFile(address, filename);
        }




    }
}
