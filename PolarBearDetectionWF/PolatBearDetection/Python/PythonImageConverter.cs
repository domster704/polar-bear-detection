using PolatBearDetection.Configuration;

namespace PolatBearDetection.Python
{
    public class PythonImageConverter : PythonExecutor
    {
        public PythonImageConverter(IPythonFilesConfiguration configuration) 
            : base(configuration.Directory, configuration.ImageConverterScript, configuration.Interpreter) { }

        protected PythonImageConverter(string directory, string script, string path) : base(directory, script, path)
        {
        }
    }
}
