namespace PolatBearDetection.Configuration
{
    public interface IBearFilesConfiguration
    {
        string OriginalFileName { get; }
        string ConvertedFileName { get; }
        string CopiedFileName { get; }
    }
}
