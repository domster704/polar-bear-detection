using System.Drawing;

namespace PolatBearDetection.ControlWrappers
{
    public interface IBearFindLabelStyle
    {
        Color Found { get; }
        Color NotFound { get; }

        string FoundText { get; }
        string NotFoundText { get; }
    }
}
