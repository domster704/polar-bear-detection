using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PolatBearDetection.Tween
{
    public class TransitionHandler
    {
        private readonly Guna2Transition _transition;
        private readonly Control _control;

        private bool _shown;

        public TransitionHandler(Guna2Transition transition, Control control, bool shown = true)
        {
            _transition = transition;
            _control = control;
            _shown = shown;
        }

        public void Process()
        {
            _shown = !_shown;

            if (_shown)
            {
                _transition.ShowSync(_control);
                return;
            }

            _transition.HideSync(_control);
        }
    }
}
