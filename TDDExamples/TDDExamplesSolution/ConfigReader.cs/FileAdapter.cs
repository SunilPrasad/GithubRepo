using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigReader.cs
{
    public class FileAdapter
    {
        public bool IsExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
