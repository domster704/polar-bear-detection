using System.IO;

namespace PolatBearDetection.Configuration
{
    public class DefaultBearFilesConfiguration : IBearFilesConfiguration
    {
        public string OriginalFileName => Combine("Bear");

        public string ConvertedFileName => Combine("BearConverted");

        public string CopiedFileName => Combine("BearConverted_Copy");

        public string ContainsBearFile => Combine("ContainsBear", ".txt");

        private string ImageExtension => ".JPG";

        private string DataDirectory => "Data";


        private string Combine(string fileName)
        {
            return Path.Combine(DataDirectory, fileName) + ImageExtension;
        }

        private string Combine(string fileName, string extension)
        {
            return Path.Combine(DataDirectory, fileName) + extension;
        }
    }
}
