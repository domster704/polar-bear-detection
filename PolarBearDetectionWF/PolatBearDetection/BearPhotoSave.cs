using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace PolatBearDetection
{
    public class BearPhotoSave
    {
        private readonly string _sourceFileName;
        private readonly string _destinationDirectory;
        private readonly string _name;

        public BearPhotoSave(string sourceFileName, string destinationDirectory, string name)
        {
            _sourceFileName = sourceFileName;
            _destinationDirectory = destinationDirectory;
            _name = name;
        }

        public void Save()
        {
            foreach (var file in GetFilesWithName(_name))
                File.Delete(file);

            var extension = Path.GetExtension(_sourceFileName);
            var newFileName = Path.Combine(_destinationDirectory, _name + extension);

            File.Copy(_sourceFileName, newFileName);
        }

        private IEnumerable<string> GetFilesWithName(string name)
        {
            return Directory.GetFiles(_destinationDirectory)
                            .Where(file => file.Contains(name));
        }
    }
}
