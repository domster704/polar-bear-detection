using System;
using System.IO;
using PolatBearDetection.Configuration;

namespace PolatBearDetection.IO
{
    public class BearInfoReader
    {
        private readonly string _file;

        public BearInfoReader(IBearFilesConfiguration configuration) : this(configuration.ContainsBearFile) { }

        public BearInfoReader(string file) => _file = file;

        public bool GetInfo()
        {
            return Convert.ToBoolean(File.ReadAllText("Data/ContainsBear.txt"));
        }
    }
}
