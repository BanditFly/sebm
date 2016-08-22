namespace se_ml
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
            this.tmpDirect = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.blueprintThumb = new System.Windows.Forms.PictureBox();
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
            this.replaceButton.Location = new System.Drawing.Point(12, 177);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(148, 23);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Block
            // 
            this.Block.Location = new System.Drawing.Point(15, 25);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(145, 20);
            this.Block.TabIndex = 3;
            this.Block.Text = "Block to replace";
            // 
            // replaceWith
            // 
            this.replaceWith.FormattingEnabled = true;
            this.replaceWith.Items.AddRange(new object[] {
            "LargeBlockArmorBlock",
            "testblock"});
            this.replaceWith.Location = new System.Drawing.Point(12, 77);
            this.replaceWith.Name = "replaceWith";
            this.replaceWith.Size = new System.Drawing.Size(148, 94);
            this.replaceWith.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Replace with:";
            // 
            // tmpDirect
            // 
            this.tmpDirect.Location = new System.Drawing.Point(27, 254);
            this.tmpDirect.Name = "tmpDirect";
            this.tmpDirect.Size = new System.Drawing.Size(100, 20);
            this.tmpDirect.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(166, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 304);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // blueprintThumb
            // 
            this.blueprintThumb.Location = new System.Drawing.Point(366, 12);
            this.blueprintThumb.Name = "blueprintThumb";
            this.blueprintThumb.Size = new System.Drawing.Size(200, 112);
            this.blueprintThumb.TabIndex = 8;
            this.blueprintThumb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 466);
            this.Controls.Add(this.blueprintThumb);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tmpDirect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceWith);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox tmpDirect;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox blueprintThumb;
    }
}

