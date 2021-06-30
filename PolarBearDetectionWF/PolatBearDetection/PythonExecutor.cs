using System.Diagnostics;

namespace PolatBearDetection
{
    public class PythonExecutor
    {
        private readonly string _directory;
        private readonly string _script;

        public PythonExecutor(string directory, string script)
        {
            _directory = directory;
            _script = script;
        }

        public void Execute()
        {
            var startInfo = new ProcessStartInfo("python")
            {
                WorkingDirectory = _directory,
                Arguments = _script,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
            };

            var process = new Process()
            {
                StartInfo = startInfo
            };

            process.Start();
        }
    }
}
