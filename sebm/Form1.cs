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


namespace sebm
{
    public partial class Form1 : Form
    {

        private string blocka;
        private string blockb;
        private string blockc;

        serverinfo si = new serverinfo();

        string[] version;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");

                for (int i = 0; i < blueprint.Length; i++)
                {
                    if (blueprint[i].Contains(blueprintSub.SelectedItem.ToString()))
                    {
                        int x = i; x--;
                        Console.WriteLine(x + i + blueprint[i]);
                        Console.WriteLine(blueprintSub.SelectedItem.ToString() + "-" + blocks.SelectedItem.ToString());

                        string bluex = blueprint[x].Replace(blueprintBlocks.SelectedItem.ToString(), blocktype.SelectedItem.ToString());
                        string bluei = blueprint[i].Replace(blueprintSub.SelectedItem.ToString(), blocks.SelectedItem.ToString());

                        blueprint[x] = bluex;
                        blueprint[i] = bluei;

                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc").Replace(blueprintBlocks.SelectedItem.ToString(), blocktype.SelectedItem.ToString()));
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc").Replace(blueprintSub.SelectedItem.ToString(), blocks.SelectedItem.ToString()));

                    }

                    progressBar1.Value = (int)((double)i / blueprint.Length * 100);

                }

                progressBar1.Value = 0;

                MessageBox.Show("Replaced Blocks!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //TODO: better exeption handling!!!
            } catch(Exception ex) { MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Improove this!!!
            smallShipBox.CheckState = CheckState.Unchecked;

           

            if (File.Exists("semlupdater.exe")) { File.Delete("semlupdater.exe"); }

            String[] allfiles = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local", "*.*", System.IO.SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                Console.WriteLine(info.Name);
                if (!checkedListBox1.Items.Contains(info.Directory.ToString().Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\", "")))
                {
                    checkedListBox1.Items.Add(info.Directory.ToString().Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\", ""));
                }
            }
            serverversion.Text = si.getsebmversion();

            if(Int32.Parse(localversion.Text.Replace("Local version: ", "").Replace(".", "")) < Int32.Parse(serverversion.Text.Replace("Server version: ", "").Replace(".", ""))) { MessageBox.Show("There is an update!" + Environment.NewLine + "Local version: " + localversion.Text.Replace("Local version: ", "") + Environment.NewLine + "Server version: " + serverversion.Text.Replace("Server version: ", ""), "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            blockCounter bc = new blockCounter();

            bc.resetCounter();

            blueprintThumb.SizeMode = PictureBoxSizeMode.Zoom;
            blueprintThumb.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\thumb.png";

            string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");

            gridsize.Text = bc.getGridsize(blueprint);
            bc.countBlocks(blueprint);

            blockcounter.Text = "Blockcount: " + bc.blockcount.ToString(); //Blocks
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (backupPath.Text != "" || backupPath.Text != "Path to blueprint backup folder")
            {
                try
                {
                    String[] allfiles = System.IO.Directory.GetFiles(backupPath.Text, "*.*", System.IO.SearchOption.AllDirectories);

                    foreach (var file in allfiles)
                    {
                        FileInfo info = new FileInfo(file);
                        Console.WriteLine(info.Name);
                        if (!checkedListBox2.Items.Contains(info.Directory.ToString().Replace(backupPath.Text + "\\", "")))
                        {
                            checkedListBox2.Items.Add(info.Directory.ToString().Replace(backupPath.Text + "\\", ""));
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Couldn't find path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void backupPath_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (backupPath.Text != "")
                {
                    tools.copyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\", backupPath.Text + "\\" + checkedListBox1.SelectedItem.ToString() + "\\");
                }
                else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch(NullReferenceException) { MessageBox.Show("Didn't selcted a blueprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(smallShipBox.CheckState == CheckState.Unchecked)
            {
                blocktype.Items.Clear();
                string[] largeBlocks = si.getLargeBlockDef();
                for (int i = 0; i < largeBlocks.Length; i++)
                {
                    string[] btype; btype = largeBlocks[i].Split('|');


                    if (!blocktype.Items.Contains(btype[0]))
                    {
                        blocktype.Items.Add(btype[0]);
                    }
                }
            } else if(smallShipBox.CheckState == CheckState.Checked)
            {
                blocktype.Items.Clear();
                string[] smallBlocks = si.getSmallBlockDef();
                for (int i = 0; i < smallBlocks.Length; i++)
                {
                    string[] btype; btype = smallBlocks[i].Split('|');


                    if (!blocktype.Items.Contains(btype[0]))
                    {
                        blocktype.Items.Add(btype[0]);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            tools.downlaodFile("http://s.thatseliyt.de/", "Updater.exe", "semlupdater.exe");
            MessageBox.Show("Update will start now!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("semlupdater.exe");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try {

                if (backupPath.Text != "")
                {
                    tools.copyDirectory(backupPath.Text + "\\" + checkedListBox2.SelectedItem.ToString() + "\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox2.SelectedItem.ToString() + "\\");
                }
                else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(NullReferenceException) { MessageBox.Show("Didn't selcted a blueprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button5_Click(object sender, EventArgs e)
        {



            if ((string)checkedListBox1.SelectedItem != "" || (string)checkedListBox1.SelectedItem != " " || (string)checkedListBox1.SelectedItem != null)
            {

                blueprintBlocks.Items.Clear();

                try
                {

                    string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");
                    for (int i = 0; i < blueprint.Length; i++)
                    {
                        if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type="))
                        {
                            blocka = blueprint[i].Replace("            <MyObjectBuilder_CubeBlock xsi:type=" + '\u0022', "");
                            blockb = blocka.Replace('\u0022' + ">", "|");
                            int x = i; x++;
                            blocka = blueprint[x].Replace("              <SubtypeName>", "");
                            blockc = blockb + blocka.Replace("</SubtypeName>", "");



                            if (!blueprintBlocks.Items.Contains(blockc.Split('|')[0]))
                            {
                                blueprintBlocks.Items.Add(blockc.Split('|')[0]);

                            }
                        }

                        progressBar1.Value = (int)((double)i / blueprint.Length * 100);

                    }

                    progressBar1.Value = 0;

                } catch(NullReferenceException)  { MessageBox.Show("Didn't selcted a blueprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            } else MessageBox.Show("Didn't selcted a blueprint!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void replaceWith_SelectedIndexChanged(object sender, EventArgs e)
        {

            blocks.Items.Clear();
            string[] largeBlocks = si.getLargeBlockDef();

            string[] smallBlocks = si.getSmallBlockDef();

            if (smallShipBox.CheckState == CheckState.Unchecked)
                {
                    for (int x = 0; x < largeBlocks.Length; x++)
                    {   
                        string[] btype; btype = largeBlocks[x].Split('|');
                        
                        if(btype[0].Contains(blocktype.SelectedItem.ToString()))
                        {
                        if (!blocks.Items.Contains(btype[1]))
                        {
                            blocks.Items.Add(btype[1]);
                        }
                    }
                       
                    }
                
                } else

            if (smallShipBox.CheckState == CheckState.Checked)
            {
                for (int x = 0; x < largeBlocks.Length; x++)
                {
                    string[] btype; btype = smallBlocks[x].Split('|');

                    if (btype[0].Contains(blocktype.SelectedItem.ToString()))
                    {
                        if (!blocks.Items.Contains(btype[1]))
                        {
                            blocks.Items.Add(btype[1]);
                        }
                    }

                }

            }

        }

        private void blueprintBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {

            blueprintSub.Items.Clear();

            string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");
            for (int i = 0; i < blueprint.Length; i++)
            {
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type="))
                {
                    blocka = blueprint[i].Replace("            <MyObjectBuilder_CubeBlock xsi:type=" + '\u0022', "");
                    blockb = blocka.Replace('\u0022' + ">", "|");
                    int x = i; x++;
                    blocka = blueprint[x].Replace("              <SubtypeName>", "");
                    blockc = blockb + blocka.Replace("</SubtypeName>", "");



                    if (blueprintBlocks.SelectedItem.ToString() == blockc.Split('|')[0])
                    {
                        if (!blueprintSub.Items.Contains(blockc.Split('|')[1]))
                        {
                            blueprintSub.Items.Add(blockc.Split('|')[1]);
                        }
                    }
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                backupPath.Text = folderBrowserDialog1.SelectedPath;
            }

            if (backupPath.Text != "" || backupPath.Text != "Path to blueprint backup folder")
            {
                try
                {
                    String[] allfiles = System.IO.Directory.GetFiles(backupPath.Text, "*.*", System.IO.SearchOption.AllDirectories);

                    foreach (var file in allfiles)
                    {
                        FileInfo info = new FileInfo(file);
                        Console.WriteLine(info.Name);
                        if (!checkedListBox2.Items.Contains(info.Directory.ToString().Replace(backupPath.Text + "\\", "")))
                        {
                            checkedListBox2.Items.Add(info.Directory.ToString().Replace(backupPath.Text + "\\", ""));
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Couldn't find path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
