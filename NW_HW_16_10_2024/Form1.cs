
namespace NW_HW_16_10_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePath();
        }

        private void OpenPathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    LocalPathTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private async Task DownloadImgAsync()
        {
            if (!string.IsNullOrWhiteSpace(LocalPathTextBox.Text) && !string.IsNullOrWhiteSpace(ImgNameTextBox.Text) && !string.IsNullOrWhiteSpace(ImgURLTextBox.Text))
            {
                string imageUrl = ImgURLTextBox.Text;
                string savePath = $"{LocalPathTextBox.Text}\\{ImgNameTextBox.Text}.img";
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                        await File.WriteAllBytesAsync(savePath, imageBytes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
        private void InitializePath()
        {
            LocalPathTextBox.Text = "C:\\Users\\user\\Pictures";
        }

        private void SaveImgButton_Click(object sender, EventArgs e)
        {
            DownloadImgAsync();
        }

        private void ClearURLButton_Click(object sender, EventArgs e)
        {
            ImgURLTextBox.Text = "";
        }
    }
}
