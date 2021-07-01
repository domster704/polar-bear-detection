namespace PolatBearDetection.Configuration
{
    public interface IPythonFilesConfiguration
    {
        string Interpreter { get; }
        string Directory { get; }
        string ImageConverterScript { get; }
    }
}
