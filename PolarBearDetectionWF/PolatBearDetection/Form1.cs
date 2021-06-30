using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PolatBearDetection
{
    public partial class MainForm : Form
    {
        private readonly TransitionHandler _findSubmenuTransitionHandler;

        public MainForm()
        {
            InitializeComponent();

            _findSubmenuTransitionHandler = new TransitionHandler(FindBearSubMenuTransition,
                                                                  FindSubmenuPanel,
                                                                  false);
        }

        private void FindMenuButton_Click(object sender, EventArgs e)
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

            var photoSave = new BearPhotoSave(openFileDialog.FileName, "Data", "Bear");

            photoSave.Save();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            PythonExecutor executor = new PythonExecutor("Python", "main.py");
            executor.Execute();
        }
    }
}
