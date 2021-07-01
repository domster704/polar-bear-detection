using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PolatBearDetection.Tween
{
    public class TransitionHandler
    {
        public bool Shown { get; private set; }

        private readonly Guna2Transition _transition;
        private readonly Control _control;

        public TransitionHandler(Guna2Transition transition, Control control, bool shown = true)
        {
            _transition = transition;
            _control = control;
            Shown = shown;
        }

        public void Process()
        {
            Shown = !Shown;

            if (Shown)
            {
                _transition.ShowSync(_control);
                return;
            }

            _transition.HideSync(_control);
        }

        public void Show()
        {
            Shown = true;
            _transition.ShowSync(_control);
        }

        public void Hide()
        {
            Shown = false;
            _transition.HideSync(_control);
        }
    }
}
