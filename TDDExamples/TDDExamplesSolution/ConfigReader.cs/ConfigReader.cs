using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigReaderUtil
{
    public class ConfigReader
    {
        public string Read(string filePath , string key)
        {
            if (File.Exists(filePath))
                throw new Exception("File does not exist");

            string[] lines = File.ReadAllLines(filePath);
            return lines[0];
        }
    }
}
