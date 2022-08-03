using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinifyAPI;

namespace TinifyImageCompression
{
    public partial class FormTinypng : Form
    {
        public string[] AllFiles = Array.Empty<string>();

        private delegate void DelShowMessage(string sMessage);

        public FormTinypng()
        {
            InitializeComponent();
            // 至 https://tinify.com/ 申請
            Tinify.Key = "1V0G68KYss0x14xfP9q2gX9nVbVwmGvB";
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_image.ShowDialog() == DialogResult.OK)
            {
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
                txtImageFolder.Text = folderBrowserDialog_image.SelectedPath;

                AllFiles = GetFilesFrom(txtImageFolder.Text, filters, true);
            }
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            var filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        private async void btnCompression_Click(object sender, EventArgs e)
        {
            var storePath = txtImageFolder.Text + @"\Compression";
            if (Directory.Exists(storePath) == false)
                Directory.CreateDirectory(storePath);

            var taskList = new List<Task>();
            foreach (var file in AllFiles)
            {
                taskList.Add(Task.Run(() =>
                {
                    var fInfo = new FileInfo(file);
                    var source = Tinify.FromFile(file);

                    source.ToFile($@"{storePath}\{fInfo.Name}").Wait();
                    AddMessage(file);
                }));
            }

            _ = Task.Run(() =>
            {
                Task.WaitAll(taskList.ToArray());
                MessageBox.Show("OK");
            });
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // 執行過一次才抓地到資料
            labCount.Text = $"ApiTotalCount - {Tinify.CompressionCount}";
        }

        private void AddMessage(string sMessage)
        {
            // 若非同執行緒
            if (this.InvokeRequired)
            {
                var del = new DelShowMessage(AddMessage);
                this.Invoke(del, sMessage);
            }
            else // 同執行緒
            {
                lstBox.Items.Add(sMessage);
            }
        }
    }
}