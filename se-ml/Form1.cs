﻿using System;
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

        string[] version;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox1.SelectedItem.ToString() + "\\bp.sbc").Replace(Block.Text, replaceWith.Text));
            MessageBox.Show("Replaced Blocks!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if(File.Exists("semlupdater.exe")) { File.Delete("semlupdater.exe"); }

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
            if (blueprint[22].Contains("<GridSizeEnum>Large</GridSizeEnum>")) { gridsize.Text = "Gridsize: Large"; }
            else
            if (blueprint[22].Contains("<GridSizeEnum>Small</GridSizeEnum>")) { gridsize.Text = "Gridsize: Small"; }

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
            if (backupPath.Text != "")
            {
                tools.copyDirectory(backupPath.Text + "\\" + checkedListBox2.SelectedItem.ToString() + "\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SpaceEngineers\\Blueprints\\local\\" + checkedListBox2.SelectedItem.ToString() + "\\");
            } else MessageBox.Show("Enter a backup path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                replaceWith.Items.Clear();
                tools.downlaodFile("http://s.thatseliyt.de/", "largeBlocks.txt", "largeBlocks.txt");
                string[] largeBlocks = File.ReadAllLines("largeBlocks.txt");
                File.Delete("largeBlocks.txt");
                for (int i = 0; i < largeBlocks.Length; i++)
                {
                    replaceWith.Items.Add(largeBlocks[i]);
                }
            } else if(smallShipBox.CheckState == CheckState.Checked)
            {
                replaceWith.Items.Clear();
                tools.downlaodFile("http://s.thatseliyt.de/", "smallBlocks.txt", "smallBlocks.txt");
                string[] smallBlocks = File.ReadAllLines("smallBlocks.txt");
                File.Delete("smallBlocks.txt");
                for (int i = 0; i < smallBlocks.Length; i++)
                {
                    replaceWith.Items.Add(smallBlocks[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            tools.downlaodFile("http://s.thatseliyt.de/", "Updater.exe", "semlupdater.exe");
            MessageBox.Show("Updatw will start now!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("semlupdater.exe");
            this.Close();
        }
    }
}
