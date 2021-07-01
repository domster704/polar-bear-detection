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

        public void SetFoundStyle()
        {
            _label.Text = _style.FoundText;
            _label.ForeColor = _style.Found;
        }

        public void SetNotFoundStyle()
        {
            _label.Text = _style.NotFoundText;
            _label.ForeColor = _style.NotFound;
        }

        public void SetStyle(bool found)
        {
            if (found)
            {
                SetFoundStyle();
                return;
            }

            SetNotFoundStyle();
        }
    }
}
