using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CopyFile2
{

    public class FileCopy
    {

        public void copyFile(String file1, String file2)
        {
            using (StreamReader reader = new StreamReader(file1))
            using (StreamWriter writer = new StreamWriter(file2))
            {
                String line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

            }

        }

    }
    class copyfile2
    {
        static void Main(string[] args)
        {

            FileCopy fc = new FileCopy();
            String file1 = @"D:\5HY4M\DOTNET PRACTICAL\DOTNET\file1.txt";
            String file2 = @"D:\5HY4M\DOTNET PRACTICAL\DOTNET\file2.txt";
            fc.copyFile(file1, file2);
        }
    }
}
