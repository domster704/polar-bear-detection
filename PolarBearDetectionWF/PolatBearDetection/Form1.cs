using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolarBearDetection
{
    public partial class MainForm : Form
    {
        private TransitionHandler _findSubmenuTransitionHandler;

        public MainForm()
        {
            InitializeComponent();

            _findSubmenuTransitionHandler = new TransitionHandler(FindBearSubMenuTransition, FindSubmenuPanel, false);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            _findSubmenuTransitionHandler.Process();
        }

        private void ChooseImageButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Images | *.png; *.jpg; *.JPEG; *.bmp"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                BearPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла. Проверьте формат файла.");
            }
        }
    }
}
