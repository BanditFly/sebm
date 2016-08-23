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

        int blockcount;
        int antennacount;
        int remotecount;
        int timercount;
        int pistonount;
        int batterycount;
        int cockpitcount;
        int doorcount;
        int cryocount;
        int lcdcount;


        private string blocka;
        private string blockb;
        private string blockc;

        string[] analyzedBlueprint;

        string[] version;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc").Replace(Block.Text, replaceWith.SelectedItem.ToString()));

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
            }

            MessageBox.Show("Replaced Blocks!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            smallShipBox.CheckState = CheckState.Checked;
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

            tools.downlaodFile("http://s.thatseliyt.de/", "semlversion.txt", "semlversion.txt");
            version = File.ReadAllLines("semlversion.txt");
            serverversion.Text = "Server version: " + version[0];
            File.Delete("semlversion.txt");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            blockcount = 0;
            antennacount = 0;
            remotecount = 0;
            timercount = 0;
            pistonount = 0;
            batterycount = 0;
            cockpitcount = 0;
            doorcount = 0;
            cryocount = 0;
            lcdcount = 0;

            blueprintThumb.SizeMode = PictureBoxSizeMode.Zoom;
            blueprintThumb.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\thumb.png";

            Console.WriteLine("Selected blueprint.");
            string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");
            Console.WriteLine(blueprint[22]);

            for (int i = 0; i < blueprint.Length; i++)
            {
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_CubeBlock\">")) { blockcount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_RadioAntenna\">")) { antennacount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_RemoteControl\">")) { remotecount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_TimerBlock\">")) { timercount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_ExtendedPistonBase\">")) { pistonount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_BatteryBlock\">")) { batterycount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_Cockpit\">")) { cockpitcount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_Door\">")) { doorcount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_CryoChamber\">")) { cryocount++; }
                if (blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=\"MyObjectBuilder_TextPanel\">")) { lcdcount++; }
                if (blueprint[i].Contains("<GridSizeEnum>Large</GridSizeEnum>")) { gridsize.Text = "Gridsize: Large"; }
                if (blueprint[i].Contains("<GridSizeEnum>Small</GridSizeEnum>")) { gridsize.Text = "Gridsize: Small"; }

            }

            blockcounter.Text = "Blockcount: " + blockcount.ToString(); //Blocks
            antennacounter.Text = "Antennas: " + antennacount.ToString(); //Antennas
            remotecounter.Text = "Remote:" + remotecount.ToString(); //Remotes
            timercounter.Text = "Timer: " + timercount.ToString(); //Timer
            pistoncounter.Text = "Piston: " + pistonount.ToString(); //Piston
            batterycounter.Text = "Battery:" + batterycount.ToString(); //Battery
            cockpitcounter.Text = "Cockpit: " + cockpitcount.ToString(); //Cockpits
            doorcounter.Text = "Door: " + doorcount.ToString(); //Doors
            cryocounter.Text = "Cryo:" + cryocount.ToString(); //Cryos
            lcdcounter.Text = "LCD:" + lcdcount.ToString(); //LCDs
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

            if (backupPath.Text != "")
            {
                tools.copyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\", backupPath.Text + "\\" + checkedListBox1.SelectedItem.ToString() + "\\");
            }
            else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(smallShipBox.CheckState == CheckState.Unchecked)
            {
                blocktype.Items.Clear();
                tools.downlaodFile("http://s.thatseliyt.de/", "largeBlocks.txt", "largeBlocks.txt");
                string[] largeBlocks = File.ReadAllLines("largeBlocks.txt");
                File.Delete("largeBlocks.txt");
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
                tools.downlaodFile("http://s.thatseliyt.de/", "smallBlocks.txt", "smallBlocks.txt");
                string[] smallBlocks = File.ReadAllLines("smallBlocks.txt");
                File.Delete("smallBlocks.txt");
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
            if (backupPath.Text != "")
            {
                tools.copyDirectory(backupPath.Text + "\\" + checkedListBox2.SelectedItem.ToString() + "\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox2.SelectedItem.ToString() + "\\");
            }
            else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            blueprintBlocks.Items.Clear();

            string[] blueprintblocks;

            string[] blueprint = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc");
            for (int i = 0; i < blueprint.Length; i++)
            {
                if(blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type="))
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
            }

        }

        private void replaceWith_SelectedIndexChanged(object sender, EventArgs e)
        {

            blocks.Items.Clear();
            tools.downlaodFile("http://s.thatseliyt.de/", "largeBlocks.txt", "largeBlocks.txt");
            string[] largeBlocks = File.ReadAllLines("largeBlocks.txt");
            File.Delete("largeBlocks.txt");

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
                        blueprintSub.Items.Add(blockc.Split('|')[1]);
                    }
                }
            }

        }
    }
}
