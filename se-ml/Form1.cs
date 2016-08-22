using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace se_ml
{
    public partial class Form1 : Form
    {

        private Bitmap MyImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(tmpDirect.Text, File.ReadAllText(tmpDirect.Text).Replace(Block.Text, replaceWith.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] allfiles = System.IO.Directory.GetFiles( Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local", "*.*", System.IO.SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                Console.WriteLine(info.Name);
                if (!checkedListBox1.Items.Contains(info.Directory.ToString().Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\", "")))
                {
                    checkedListBox1.Items.Add(info.Directory.ToString().Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\", ""));
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            blueprintThumb.SizeMode = PictureBoxSizeMode.Zoom;
            blueprintThumb.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\thumb.png";
        }
    }
}
