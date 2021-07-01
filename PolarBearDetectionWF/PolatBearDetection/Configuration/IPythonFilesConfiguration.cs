namespace PolatBearDetection.Configuration
{
    public interface IPythonFilesConfiguration
    {
        string Path { get; }
        string Directory { get; }
        string ImageConverterScript { get; }
    }
}
