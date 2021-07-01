using System.IO;

namespace PolatBearDetection.Configuration
{
    public class DefaultBearFilesConfiguration : IBearFilesConfiguration
    {
        public string OriginalFileName => Combine("Bear");

        public string ConvertedFileName => Combine("BearConverted");

        public string CopiedFileName => Combine("BearConverted_Copy");

        private string Extension => ".JPG";

        private string DataDirectory => "Data";


        private string Combine(string fileName)
        {
            return Path.Combine(DataDirectory, fileName) + Extension;
        }
    }
}
