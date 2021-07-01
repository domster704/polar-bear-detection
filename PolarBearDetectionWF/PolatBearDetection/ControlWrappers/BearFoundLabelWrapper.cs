using System.Windows.Forms;

namespace PolatBearDetection.ControlWrappers
{
    public class BearFoundLabelWrapper
    {
        private readonly Label _label;
        private readonly IBearFindLabelStyle _style;

        public BearFoundLabelWrapper(Label label, IBearFindLabelStyle style)
        {
            _label = label;
            _style = style;
        }

        public void SetEmptyText()
        {
            _label.Text = string.Empty;
        }

        public void SetBearFoundStyle()
        {
            _label.ForeColor = _style.Found;
        }

        public void SetBearNotFoundStyle()
        {
            _label.ForeColor = _style.NotFound;
        }
    }
}
