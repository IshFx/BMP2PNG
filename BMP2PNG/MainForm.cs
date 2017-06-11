using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP2PNG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // Get files dropped
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Prepare Progressbar
            Main_progressBar.Style = ProgressBarStyle.Continuous;
            Main_progressBar.Value = 0;
            Main_progressBar.Maximum = files.Count();

            // Check delete files
            bool DeleteFiles = Main_checkbox.Checked;

            foreach (string file in files)
            {
                // Check extension
                if ((System.IO.Path.GetExtension(file).ToLower()) == ".bmp")
                {
                    try
                    {
                        Image img;
                        using (System.IO.Stream stream = System.IO.File.OpenRead(file))
                        {
                            // Read image
                            img = Image.FromStream(stream);

                            // Convert image
                            img.Save(System.IO.Path.ChangeExtension(file, ".png"), System.Drawing.Imaging.ImageFormat.Png);

                            // Dispose ressources
                            img.Dispose();
                        }

                        // Delete image if asked to
                        if (DeleteFiles) System.IO.File.Delete(file);
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                    }

                    Main_progressBar.Increment(1);

                }
            }

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

    }
}
