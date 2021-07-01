using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using PolatBearDetection.Extensions;
using PolatBearDetection.Properties;
using PolatBearDetection.Tween;
using PolatBearDetection.Python;
using PolatBearDetection.IO;
using PolatBearDetection.Configuration;

namespace PolatBearDetection
{
    public partial class MainForm : Form
    {
        private readonly TransitionHandler _findSubmenuTransitionHandler;
        private readonly PythonExecutor _imageConverter;

        private readonly IBearFilesConfiguration _bearFilesConfiguration;
        private readonly IPythonFilesConfiguration _pythonFilesConfiguration;

        public MainForm()
        {
            InitializeComponent();

            _bearFilesConfiguration = new DefaultBearFilesConfiguration();
            _pythonFilesConfiguration = new DefaultPythonFilesConfiguration();

            _findSubmenuTransitionHandler = new TransitionHandler(FindBearSubMenuTransition,
                                                                  FindSubmenuPanel,
                                                                  false);

            _imageConverter = new PythonImageConverter(_pythonFilesConfiguration);
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

            var photoSave = new BearPhotoSave(openFileDialog.FileName, _bearFilesConfiguration);

            photoSave.Save();
        }

        private async void FindButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_bearFilesConfiguration.OriginalFileName) == false)
            {
                MessageBox.Show("Загрузите файл");
                return;
            }

            var image = Resources.Preloader;
            BearPictureBox.RefreshWithImage(image);

            await _imageConverter.ExecuteAsync().ContinueWith(task =>
            {
                var photoSave = new BearPhotoSave(_bearFilesConfiguration);
                photoSave.Save();

                BearPictureBox.Image = new Bitmap(_bearFilesConfiguration.CopiedFileName);
            });
        }

        private void SaveResultImageButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_bearFilesConfiguration.CopiedFileName) == false)
            {
                MessageBox.Show("Результат отсутсвует. Нажмите \"Найти\"");
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                FileName = "BearFile",
                Filter = "*.JPG | *.JPG;"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var photoSave = new BearPhotoSave(_bearFilesConfiguration.CopiedFileName, saveFileDialog.FileName);
            photoSave.Save();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            BearPictureBox.RefreshWithImage(Resources.logo1);

            var bearFiles = Directory.GetFiles("Data").Where(name => name.Contains("Bear"));

            foreach (var file in bearFiles)
            {
                File.Delete(file);
            }
        }
    }
}
