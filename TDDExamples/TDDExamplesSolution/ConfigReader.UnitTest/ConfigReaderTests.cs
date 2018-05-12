using System;
using System.IO;
using ConfigReader.cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace ConfigReader.UnitTest
{
    [TestClass]
    public class ConfigReaderTests
    {
        private IFileAdapter _fileAdapter;
        [TestInitialize]
        public void Init()
        {
            _fileAdapter = MockRepository.GenerateStub<IFileAdapter>();
        }
        
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ReaderShouldThrowExceptionWhenFileDoesNotExit()
        {
            var configReader = new ConfigReaderUtil.ConfigReader(_fileAdapter);
            _fileAdapter.Stub<IFileAdapter>(f => f.Exists("config.json")).Return(false);

            configReader.Read("config.json","environment");

        }
    }
}
