using ConfigReader.cs;
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
        private IFileAdapter _fileAdapter;
        public ConfigReader(IFileAdapter fileAdapter)
        {
            _fileAdapter = fileAdapter;
        }
        //public string Read(string filePath, string key)
        //{
        //    if (!File.Exists(filePath))
        //        throw new Exception("File does not exist");

        //    string[] lines = File.ReadAllLines(filePath);
        //    return lines[0];
        //}

        public string Read(string filePath, string key)
        {
            if (_fileAdapter.Exists(filePath))
                throw new FileNotFoundException("File does not exist");

            string[] lines = _fileAdapter.ReadAllLines(filePath);
            return lines[0];
        }
    }
}
