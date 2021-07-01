using System.Drawing;
using System.Windows.Forms;

namespace PolatBearDetection.Extensions
{
    public static class PictureBoxExtensions
    {
        public static void RefreshWithImage(this PictureBox pictureBox, Image image)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = image;
            pictureBox.Refresh();
        }
    }
}
