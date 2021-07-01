using PolatBearDetection.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PolatBearDetection.Python
{
    public class PythonExecutor
    {
        private readonly string _path;
        private readonly string _directory;
        private readonly string _script;
        private readonly Process _process;

        public PythonExecutor(string directory, string script, string path)
        {
            _path = path;
            _script = script;
            _directory = directory;
            _process = CreateProcess();
        }

        public void Execute()
        {
            _process.Start();
            _process.WaitForExit();
        }

        public async Task ExecuteAsync()
        {
            await Task.Run(() => Execute());
        }

        private Process CreateProcess()
        {
            var startInfo = new ProcessStartInfo("Python")
            {
                FileName = _path,
                WorkingDirectory = _directory,
                Arguments = _script,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
            };

            return new Process()
            {
                StartInfo = startInfo
            };
        }
    }
}
