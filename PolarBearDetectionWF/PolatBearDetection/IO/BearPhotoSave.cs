using System.IO;
using PolatBearDetection.Configuration;

namespace PolatBearDetection.IO
{
    public class BearPhotoSave
    {
        private readonly string _sourceFileName;
        private readonly string _destinationFileName;

        public BearPhotoSave(IBearFilesConfiguration configuration) : this (configuration.ConvertedFileName, configuration.CopiedFileName) { }

        public BearPhotoSave(string sourceFileName, IBearFilesConfiguration configuration)
            : this(sourceFileName, configuration.OriginalFileName) { }

        public BearPhotoSave(string sourceFileName, string destinationFileName)
        {
            _sourceFileName = sourceFileName;
            _destinationFileName = destinationFileName;
        }

        public void Save()
        {
            File.Copy(_sourceFileName, _destinationFileName, true);
        }
    }
}
