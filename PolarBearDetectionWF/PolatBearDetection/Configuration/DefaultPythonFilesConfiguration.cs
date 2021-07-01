namespace PolatBearDetection.Configuration
{
    public class DefaultPythonFilesConfiguration : IPythonFilesConfiguration
    {
        public string Path => "Python38/python.exe";

        public string ImageConverterScript => "image_converter.py";

        public string Directory => "Data";
    }
}
