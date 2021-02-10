using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop12o12zDirectoryList
{
    class Program
    {
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            var dirInf = new List<DirectoryInfo>();
            foreach (var file in files)
            {
                if (file.Extension == ".mp3" || file.Extension == ".wav")
                {
                    bool flag = true;
                    for (int i = 0; i < dirInf.Count; i++)
                    {
                        if (dirInf[i].FullName == file.Directory.FullName)
                            flag = false;
                    }
                    if (flag)
                        dirInf.Add(file.Directory);
                }
            }
            foreach ( var e in dirInf)
                Console.WriteLine(e);
            return dirInf;
        }
        static void Main(string[] args)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (var file in Directory.GetFiles(@"F:\МУЗЫКА\POP русский\Дискотека авария"))
            {
                files.Add(new FileInfo(file));
            }
            foreach (var file in Directory.GetFiles(@"F:\МУЗЫКА\РЕТРО\14. Love Radio"))
            {
                files.Add(new FileInfo(file));
            }
            foreach (var file in Directory.GetFiles(@"F:\МУЗЫКА\КЛАССИКА\01_Classic"))
            {
                files.Add(new FileInfo(file));
            }
            GetAlbums(files);
            Console.ReadKey();
        }
    }
}
