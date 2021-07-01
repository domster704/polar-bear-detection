using System.Drawing;

namespace PolatBearDetection.ControlWrappers
{
    public class DefaultFindLabelStyle : IBearFindLabelStyle
    {
        public Color Found => Color.FromArgb(104, 237, 198);

        public Color NotFound => Color.Crimson;
    }
}
