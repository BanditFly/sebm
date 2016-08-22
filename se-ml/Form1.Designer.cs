﻿namespace se_ml
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.Block = new System.Windows.Forms.TextBox();
            this.replaceWith = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.blueprintThumb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridsize = new System.Windows.Forms.Label();
            this.blockcounter = new System.Windows.Forms.Label();
            this.antennacounter = new System.Windows.Forms.Label();
            this.remotecounter = new System.Windows.Forms.Label();
            this.timercounter = new System.Windows.Forms.Label();
            this.pistoncounter = new System.Windows.Forms.Label();
            this.batterycounter = new System.Windows.Forms.Label();
            this.cockpitcounter = new System.Windows.Forms.Label();
            this.doorcounter = new System.Windows.Forms.Label();
            this.cryocounter = new System.Windows.Forms.Label();
            this.lcdcounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.smallShipBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.serverversion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block replacer";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(12, 431);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(191, 23);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Block
            // 
            this.Block.Location = new System.Drawing.Point(15, 25);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(188, 20);
            this.Block.TabIndex = 3;
            this.Block.Text = "Blockid to replace";
            // 
            // replaceWith
            // 
            this.replaceWith.FormattingEnabled = true;
            this.replaceWith.Items.AddRange(new object[] {
            "LargeBlockArmorBlock",
            "LargeHeavyBlockArmorBlock",
            "LargeBlockInteriorWall",
            "LargeBlockBatteryBlock",
            "LargeBlockRemoteControl",
            "LargeBlockCockpitSeat",
            "LargeBlockSmallGenerator",
            "LargeBlockCryoChamber",
            "LargeBlockSmallHydrogenThrust",
            "LargeBlockSmallAtmosphericThrust",
            "LargeBlockSmallThrust",
            "LargeBlockSlideDoor",
            "LargeBlockGyro",
            "LargeBlockSmallContainer"});
            this.replaceWith.Location = new System.Drawing.Point(12, 64);
            this.replaceWith.Name = "replaceWith";
            this.replaceWith.Size = new System.Drawing.Size(191, 334);
            this.replaceWith.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Replace with:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(209, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 394);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // blueprintThumb
            // 
            this.blueprintThumb.Location = new System.Drawing.Point(409, 25);
            this.blueprintThumb.Name = "blueprintThumb";
            this.blueprintThumb.Size = new System.Drawing.Size(200, 112);
            this.blueprintThumb.TabIndex = 8;
            this.blueprintThumb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blueprints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Info:";
            // 
            // gridsize
            // 
            this.gridsize.AutoSize = true;
            this.gridsize.Location = new System.Drawing.Point(406, 168);
            this.gridsize.Name = "gridsize";
            this.gridsize.Size = new System.Drawing.Size(47, 13);
            this.gridsize.TabIndex = 12;
            this.gridsize.Text = "Gridsize:";
            // 
            // blockcounter
            // 
            this.blockcounter.AutoSize = true;
            this.blockcounter.Location = new System.Drawing.Point(406, 181);
            this.blockcounter.Name = "blockcounter";
            this.blockcounter.Size = new System.Drawing.Size(64, 13);
            this.blockcounter.TabIndex = 13;
            this.blockcounter.Text = "Blockcount:";
            // 
            // antennacounter
            // 
            this.antennacounter.AutoSize = true;
            this.antennacounter.Location = new System.Drawing.Point(407, 194);
            this.antennacounter.Name = "antennacounter";
            this.antennacounter.Size = new System.Drawing.Size(55, 13);
            this.antennacounter.TabIndex = 14;
            this.antennacounter.Text = "Antennas:";
            // 
            // remotecounter
            // 
            this.remotecounter.AutoSize = true;
            this.remotecounter.Location = new System.Drawing.Point(406, 207);
            this.remotecounter.Name = "remotecounter";
            this.remotecounter.Size = new System.Drawing.Size(47, 13);
            this.remotecounter.TabIndex = 15;
            this.remotecounter.Text = "Remote:";
            // 
            // timercounter
            // 
            this.timercounter.AutoSize = true;
            this.timercounter.Location = new System.Drawing.Point(406, 220);
            this.timercounter.Name = "timercounter";
            this.timercounter.Size = new System.Drawing.Size(36, 13);
            this.timercounter.TabIndex = 16;
            this.timercounter.Text = "Timer:";
            // 
            // pistoncounter
            // 
            this.pistoncounter.AutoSize = true;
            this.pistoncounter.Location = new System.Drawing.Point(407, 233);
            this.pistoncounter.Name = "pistoncounter";
            this.pistoncounter.Size = new System.Drawing.Size(39, 13);
            this.pistoncounter.TabIndex = 17;
            this.pistoncounter.Text = "Piston:";
            // 
            // batterycounter
            // 
            this.batterycounter.AutoSize = true;
            this.batterycounter.Location = new System.Drawing.Point(407, 246);
            this.batterycounter.Name = "batterycounter";
            this.batterycounter.Size = new System.Drawing.Size(43, 13);
            this.batterycounter.TabIndex = 18;
            this.batterycounter.Text = "Battery:";
            // 
            // cockpitcounter
            // 
            this.cockpitcounter.AutoSize = true;
            this.cockpitcounter.Location = new System.Drawing.Point(406, 259);
            this.cockpitcounter.Name = "cockpitcounter";
            this.cockpitcounter.Size = new System.Drawing.Size(46, 13);
            this.cockpitcounter.TabIndex = 19;
            this.cockpitcounter.Text = "Cockpit:";
            // 
            // doorcounter
            // 
            this.doorcounter.AutoSize = true;
            this.doorcounter.Location = new System.Drawing.Point(406, 272);
            this.doorcounter.Name = "doorcounter";
            this.doorcounter.Size = new System.Drawing.Size(33, 13);
            this.doorcounter.TabIndex = 20;
            this.doorcounter.Text = "Door:";
            // 
            // cryocounter
            // 
            this.cryocounter.AutoSize = true;
            this.cryocounter.Location = new System.Drawing.Point(407, 285);
            this.cryocounter.Name = "cryocounter";
            this.cryocounter.Size = new System.Drawing.Size(72, 13);
            this.cryocounter.TabIndex = 21;
            this.cryocounter.Text = "Cryochamber:";
            // 
            // lcdcounter
            // 
            this.lcdcounter.AutoSize = true;
            this.lcdcounter.Location = new System.Drawing.Point(407, 298);
            this.lcdcounter.Name = "lcdcounter";
            this.lcdcounter.Size = new System.Drawing.Size(31, 13);
            this.lcdcounter.TabIndex = 22;
            this.lcdcounter.Text = "LCD:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Restore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(615, 48);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(193, 379);
            this.checkedListBox2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Backed up blueprints";
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(615, 25);
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(143, 20);
            this.backupPath.TabIndex = 27;
            this.backupPath.Text = "Path to blueprint backup folder";
            this.backupPath.TextChanged += new System.EventHandler(this.backupPath_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 20);
            this.button3.TabIndex = 28;
            this.button3.Text = "Load backups";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // smallShipBox
            // 
            this.smallShipBox.AutoSize = true;
            this.smallShipBox.Location = new System.Drawing.Point(12, 410);
            this.smallShipBox.Name = "smallShipBox";
            this.smallShipBox.Size = new System.Drawing.Size(73, 17);
            this.smallShipBox.TabIndex = 29;
            this.smallShipBox.Text = "Small ship";
            this.smallShipBox.UseVisualStyleBackColor = true;
            this.smallShipBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "This version: 1.0.3";
            // 
            // serverversion
            // 
            this.serverversion.AutoSize = true;
            this.serverversion.Location = new System.Drawing.Point(412, 406);
            this.serverversion.Name = "serverversion";
            this.serverversion.Size = new System.Drawing.Size(92, 13);
            this.serverversion.TabIndex = 32;
            this.serverversion.Text = "Version on server:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.serverversion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.smallShipBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.backupPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lcdcounter);
            this.Controls.Add(this.cryocounter);
            this.Controls.Add(this.doorcounter);
            this.Controls.Add(this.cockpitcounter);
            this.Controls.Add(this.batterycounter);
            this.Controls.Add(this.pistoncounter);
            this.Controls.Add(this.timercounter);
            this.Controls.Add(this.remotecounter);
            this.Controls.Add(this.antennacounter);
            this.Controls.Add(this.blockcounter);
            this.Controls.Add(this.gridsize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueprintThumb);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceWith);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "SE-ML";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueprintThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.TextBox Block;
        private System.Windows.Forms.CheckedListBox replaceWith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox blueprintThumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gridsize;
        private System.Windows.Forms.Label blockcounter;
        private System.Windows.Forms.Label antennacounter;
        private System.Windows.Forms.Label remotecounter;
        private System.Windows.Forms.Label timercounter;
        private System.Windows.Forms.Label pistoncounter;
        private System.Windows.Forms.Label batterycounter;
        private System.Windows.Forms.Label cockpitcounter;
        private System.Windows.Forms.Label doorcounter;
        private System.Windows.Forms.Label cryocounter;
        private System.Windows.Forms.Label lcdcounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox backupPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox smallShipBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label serverversion;
    }
}

