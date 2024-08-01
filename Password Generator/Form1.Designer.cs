namespace Password.Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxpw = new TextBox();
            lbltitle = new Label();
            Btngen = new Button();
            Btncopy = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            trackBarlength = new TrackBar();
            lbllength = new Label();
            label1 = new Label();
            lblnumlength = new Label();
            lbloptions = new Label();
            lblError = new Label();
            BtnSave = new Button();
            textBoxLabel = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openLastUsedFolderToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)trackBarlength).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxpw
            // 
            textBoxpw.Location = new Point(265, 201);
            textBoxpw.Margin = new Padding(4, 5, 4, 5);
            textBoxpw.Name = "textBoxpw";
            textBoxpw.Size = new Size(644, 31);
            textBoxpw.TabIndex = 0;
            textBoxpw.TextChanged += textBox1_TextChanged;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.White;
            lbltitle.Location = new Point(237, 15);
            lbltitle.Margin = new Padding(4, 0, 4, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(722, 96);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "Password Generator";
            // 
            // Btngen
            // 
            Btngen.BackColor = Color.DarkKhaki;
            Btngen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btngen.ForeColor = Color.Black;
            Btngen.Location = new Point(95, 613);
            Btngen.Margin = new Padding(4, 5, 4, 5);
            Btngen.Name = "Btngen";
            Btngen.Size = new Size(234, 95);
            Btngen.TabIndex = 2;
            Btngen.Text = "Generate Password";
            Btngen.UseVisualStyleBackColor = false;
            Btngen.Click += Btngen_Click;
            // 
            // Btncopy
            // 
            Btncopy.BackColor = Color.DarkKhaki;
            Btncopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btncopy.Location = new Point(431, 613);
            Btncopy.Margin = new Padding(4, 5, 4, 5);
            Btncopy.Name = "Btncopy";
            Btncopy.Size = new Size(234, 95);
            Btncopy.TabIndex = 3;
            Btncopy.Text = "Copy Password";
            Btncopy.UseVisualStyleBackColor = false;
            Btncopy.Click += Btncopy_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(220, 385);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lower Case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(431, 385);
            checkBox2.Margin = new Padding(4, 5, 4, 5);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(134, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Upper Case";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(656, 385);
            checkBox3.Margin = new Padding(4, 5, 4, 5);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 29);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(851, 385);
            checkBox4.Margin = new Padding(4, 5, 4, 5);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(193, 29);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Special Characters";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // trackBarlength
            // 
            trackBarlength.BackColor = Color.Gray;
            trackBarlength.Location = new Point(237, 513);
            trackBarlength.Margin = new Padding(4, 5, 4, 5);
            trackBarlength.Name = "trackBarlength";
            trackBarlength.Size = new Size(659, 69);
            trackBarlength.TabIndex = 8;
            trackBarlength.Scroll += trackBar1_Scroll;
            // 
            // lbllength
            // 
            lbllength.AutoSize = true;
            lbllength.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbllength.ForeColor = Color.White;
            lbllength.Location = new Point(343, 443);
            lbllength.Margin = new Padding(4, 0, 4, 0);
            lbllength.Name = "lbllength";
            lbllength.Size = new Size(361, 55);
            lbllength.TabIndex = 9;
            lbllength.Text = "Password Length:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(141, 201);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "Password:";
            // 
            // lblnumlength
            // 
            lblnumlength.AutoSize = true;
            lblnumlength.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblnumlength.ForeColor = Color.White;
            lblnumlength.Location = new Point(694, 443);
            lblnumlength.Margin = new Padding(4, 0, 4, 0);
            lblnumlength.Name = "lblnumlength";
            lblnumlength.Size = new Size(48, 55);
            lblnumlength.TabIndex = 11;
            lblnumlength.Text = "1";
            // 
            // lbloptions
            // 
            lbloptions.AutoSize = true;
            lbloptions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbloptions.ForeColor = Color.White;
            lbloptions.Location = new Point(68, 374);
            lbloptions.Margin = new Padding(4, 0, 4, 0);
            lbloptions.Name = "lbloptions";
            lbloptions.Size = new Size(118, 40);
            lbloptions.TabIndex = 12;
            lbloptions.Text = "Options";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(288, 298);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 54);
            lblError.TabIndex = 13;
            lblError.Click += lblError_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.DarkKhaki;
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Location = new Point(767, 613);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(234, 95);
            BtnSave.TabIndex = 14;
            BtnSave.Text = "Save to Notepad";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // textBoxLabel
            // 
            textBoxLabel.Location = new Point(400, 243);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(357, 31);
            textBoxLabel.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(170, 246);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 16;
            label2.Text = "Label Your Password:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 33);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openLastUsedFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openLastUsedFolderToolStripMenuItem
            // 
            openLastUsedFolderToolStripMenuItem.Name = "openLastUsedFolderToolStripMenuItem";
            openLastUsedFolderToolStripMenuItem.Size = new Size(294, 34);
            openLastUsedFolderToolStripMenuItem.Text = "Open Last Used Folder";
            openLastUsedFolderToolStripMenuItem.Click += openLastUsedFolderToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1143, 750);
            Controls.Add(label2);
            Controls.Add(textBoxLabel);
            Controls.Add(BtnSave);
            Controls.Add(lblError);
            Controls.Add(lbloptions);
            Controls.Add(lblnumlength);
            Controls.Add(label1);
            Controls.Add(lbllength);
            Controls.Add(trackBarlength);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Btncopy);
            Controls.Add(Btngen);
            Controls.Add(lbltitle);
            Controls.Add(textBoxpw);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarlength).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxpw;
        private Label lbltitle;
        private Button Btngen;
        private Button Btncopy;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private TrackBar trackBarlength;
        private Label lbllength;
        private Label label1;
        private Label lblnumlength;
        private Label lbloptions;
        private Label lblError;
        private Button BtnSave;
        private TextBox textBoxLabel;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openLastUsedFolderToolStripMenuItem;
    }
}