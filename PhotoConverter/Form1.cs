using System;
using System.Windows.Forms;
using System.Drawing;

namespace PhotoConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
            // Load the image.
            //Image image1 = Image.FromFile(@"C:\test.bmp");

            // Save the image in JPEG format.
            //image1.Save(@"C:\test.jpg", Imaging.ImageFormat.Jpeg);

            // Save the image in GIF format.
            //image1.Save(@"C:\test.gif", Imaging.ImageFormat.Gif);

            // Save the image in PNG format.
            //image1.Save(@"C:\test.png", Imaging.ImageFormat.Png); 
            }//EXAMPLES
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();
            files.Multiselect = true;
            files.FileName = "Picture(s)";
            files.Filter = "BMP|*.bmp|PNG|*.png|JPG|*.jpg|GIF|*.gif|" +
                "ICON|*.ico|EMF|*.emf|EXIF|*.exif|TIFF|*.tiff|WMF|*.wmf";
            files.CheckFileExists = true;
            files.Title = "Adding file(s)";
            if(files.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in files.FileNames)
                {
                    string Path = file;
                    string Name = System.IO.Path.GetFileNameWithoutExtension(file);
                    ListViewItem Item = new ListViewItem();
                    Item.Tag = Path;
                    Item.Text = Name;
                    listView1.Items.Add(Item);
                    toolStripTextBox1.Text = "Items: " + listView1.Items.Count;
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".png";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if(f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".jpg";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".gif";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Gif);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".bmp";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void tIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".tiff";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Tiff);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void eXIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".exif";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Exif);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void wMFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".wmf";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Wmf);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void eXFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".emf";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Emf);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void iCONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            MessageBox.Show("Select dir to save pictures", "PhotoConverter - Portable");
            if (f.ShowDialog() == DialogResult.OK)
            {
                Dir = f.SelectedPath + @"\";
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string Path = (string)item.Tag;
                string Name = item.Text;
                string Ext = ".ico";
                try
                {
                    Image image = Image.FromFile(Path);
                    image.Save(Dir + Name + Ext, System.Drawing.Imaging.ImageFormat.Icon);
                }
                catch
                {
                    MessageBox.Show("Failed to convert some file", "PhotoConverter - Portable");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                ("https://github.com/Spearton666/PhotoConverterPortable");
        }
    }
}