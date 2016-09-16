namespace sebm
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
            this.blocktype = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.blueprintThumb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridsize = new System.Windows.Forms.Label();
            this.blockcounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backupPath = new System.Windows.Forms.TextBox();
            this.smallShipBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.localversion = new System.Windows.Forms.Label();
            this.serverversion = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.blueprintBlocks = new System.Windows.Forms.CheckedListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.blocks = new System.Windows.Forms.CheckedListBox();
            this.blueprintSub = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block database:";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(622, 428);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(191, 23);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Replace blocks";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // blocktype
            // 
            this.blocktype.FormattingEnabled = true;
            this.blocktype.Items.AddRange(new object[] {
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
            this.blocktype.Location = new System.Drawing.Point(622, 22);
            this.blocktype.Name = "blocktype";
            this.blocktype.Size = new System.Drawing.Size(191, 214);
            this.blocktype.TabIndex = 4;
            this.blocktype.SelectedIndexChanged += new System.EventHandler(this.replaceWith_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 394);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // blueprintThumb
            // 
            this.blueprintThumb.Location = new System.Drawing.Point(217, 22);
            this.blueprintThumb.Name = "blueprintThumb";
            this.blueprintThumb.Size = new System.Drawing.Size(200, 112);
            this.blueprintThumb.TabIndex = 8;
            this.blueprintThumb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blueprints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Info:";
            // 
            // gridsize
            // 
            this.gridsize.AutoSize = true;
            this.gridsize.Location = new System.Drawing.Point(214, 165);
            this.gridsize.Name = "gridsize";
            this.gridsize.Size = new System.Drawing.Size(47, 13);
            this.gridsize.TabIndex = 12;
            this.gridsize.Text = "Gridsize:";
            // 
            // blockcounter
            // 
            this.blockcounter.AutoSize = true;
            this.blockcounter.Location = new System.Drawing.Point(214, 178);
            this.blockcounter.Name = "blockcounter";
            this.blockcounter.Size = new System.Drawing.Size(64, 13);
            this.blockcounter.TabIndex = 13;
            this.blockcounter.Text = "Blockcount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(819, 45);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(193, 379);
            this.checkedListBox2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Backed up blueprints";
            // 
            // backupPath
            // 
            this.backupPath.Location = new System.Drawing.Point(819, 22);
            this.backupPath.Name = "backupPath";
            this.backupPath.Size = new System.Drawing.Size(117, 20);
            this.backupPath.TabIndex = 27;
            this.backupPath.Text = "Path";
            this.backupPath.TextChanged += new System.EventHandler(this.backupPath_TextChanged);
            // 
            // smallShipBox
            // 
            this.smallShipBox.AutoSize = true;
            this.smallShipBox.Checked = true;
            this.smallShipBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smallShipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallShipBox.Location = new System.Drawing.Point(622, 407);
            this.smallShipBox.Name = "smallShipBox";
            this.smallShipBox.Size = new System.Drawing.Size(191, 16);
            this.smallShipBox.TabIndex = 29;
            this.smallShipBox.Text = "Small ship (Downloads new defenitions!)";
            this.smallShipBox.UseVisualStyleBackColor = true;
            this.smallShipBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // localversion
            // 
            this.localversion.AutoSize = true;
            this.localversion.Location = new System.Drawing.Point(220, 382);
            this.localversion.Name = "localversion";
            this.localversion.Size = new System.Drawing.Size(100, 13);
            this.localversion.TabIndex = 31;
            this.localversion.Text = "Local version: 1.0.7";
            // 
            // serverversion
            // 
            this.serverversion.AutoSize = true;
            this.serverversion.Location = new System.Drawing.Point(220, 403);
            this.serverversion.Name = "serverversion";
            this.serverversion.Size = new System.Drawing.Size(92, 13);
            this.serverversion.TabIndex = 32;
            this.serverversion.Text = "Version on server:";
            this.serverversion.Click += new System.EventHandler(this.serverversion_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(423, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Analyze Blueprints";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // blueprintBlocks
            // 
            this.blueprintBlocks.FormattingEnabled = true;
            this.blueprintBlocks.Location = new System.Drawing.Point(423, 22);
            this.blueprintBlocks.Name = "blueprintBlocks";
            this.blueprintBlocks.Size = new System.Drawing.Size(193, 214);
            this.blueprintBlocks.TabIndex = 34;
            this.blueprintBlocks.SelectedIndexChanged += new System.EventHandler(this.blueprintBlocks_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(819, 428);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Restore blueprint";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Blocks in blueprint";
            // 
            // blocks
            // 
            this.blocks.FormattingEnabled = true;
            this.blocks.Location = new System.Drawing.Point(622, 251);
            this.blocks.Name = "blocks";
            this.blocks.Size = new System.Drawing.Size(191, 154);
            this.blocks.TabIndex = 37;
            // 
            // blueprintSub
            // 
            this.blueprintSub.FormattingEnabled = true;
            this.blueprintSub.Location = new System.Drawing.Point(423, 242);
            this.blueprintSub.Name = "blueprintSub";
            this.blueprintSub.Size = new System.Drawing.Size(193, 184);
            this.blueprintSub.TabIndex = 38;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 467);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1000, 24);
            this.progressBar1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(942, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 20);
            this.button2.TabIndex = 40;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.blueprintSub);
            this.Controls.Add(this.blocks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.blueprintBlocks);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.serverversion);
            this.Controls.Add(this.localversion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.smallShipBox);
            this.Controls.Add(this.backupPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blockcounter);
            this.Controls.Add(this.gridsize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueprintThumb);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.blocktype);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "SEBM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueprintThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.CheckedListBox blocktype;
        private System.Windows.Forms.PictureBox blueprintThumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gridsize;
        private System.Windows.Forms.Label blockcounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox backupPath;
        private System.Windows.Forms.CheckBox smallShipBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label localversion;
        private System.Windows.Forms.Label serverversion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox blueprintBlocks;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox blocks;
        private System.Windows.Forms.CheckedListBox blueprintSub;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
    }
}

