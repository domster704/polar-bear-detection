using System.Windows.Forms;

namespace PolatBearDetection.Extensions
{
    public static class ControlExtensions
    {
        public static void ShowAndRefresh(this Control control)
        {
            control.Show();
            control.Refresh();
        }
    }
}
