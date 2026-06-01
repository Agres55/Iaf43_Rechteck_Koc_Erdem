namespace projekt_Rechteck
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
            lblBreite = new Label();
            lblHoehe = new Label();
            lblFleache = new Label();
            lblUmfang = new Label();
            tbxBreite = new TextBox();
            tbxHoehe = new TextBox();
            tbxFleache = new TextBox();
            tbxUmfang = new TextBox();
            btnReinzoomen = new Button();
            btnRauszoomen = new Button();
            btnDrehen = new Button();
            SuspendLayout();
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(81, 100);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(43, 15);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite :";
            lblBreite.Click += label1_Click;
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(81, 156);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 15);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Hoehe :";
            // 
            // lblFleache
            // 
            lblFleache.AutoSize = true;
            lblFleache.Location = new Point(81, 248);
            lblFleache.Name = "lblFleache";
            lblFleache.Size = new Size(53, 15);
            lblFleache.TabIndex = 3;
            lblFleache.Text = "Fleache :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(81, 304);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(56, 15);
            lblUmfang.TabIndex = 4;
            lblUmfang.Text = "Umfang :";
            // 
            // tbxBreite
            // 
            tbxBreite.BackColor = SystemColors.ScrollBar;
            tbxBreite.ForeColor = SystemColors.ScrollBar;
            tbxBreite.Location = new Point(224, 92);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(100, 23);
            tbxBreite.TabIndex = 5;
            // 
            // tbxHoehe
            // 
            tbxHoehe.BackColor = SystemColors.ScrollBar;
            tbxHoehe.ForeColor = SystemColors.ScrollBar;
            tbxHoehe.Location = new Point(224, 148);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(100, 23);
            tbxHoehe.TabIndex = 6;
            // 
            // tbxFleache
            // 
            tbxFleache.BackColor = SystemColors.ScrollBar;
            tbxFleache.ForeColor = SystemColors.ScrollBar;
            tbxFleache.Location = new Point(224, 240);
            tbxFleache.Name = "tbxFleache";
            tbxFleache.ReadOnly = true;
            tbxFleache.Size = new Size(100, 23);
            tbxFleache.TabIndex = 7;
            // 
            // tbxUmfang
            // 
            tbxUmfang.BackColor = SystemColors.ScrollBar;
            tbxUmfang.ForeColor = SystemColors.ScrollBar;
            tbxUmfang.Location = new Point(224, 304);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(100, 23);
            tbxUmfang.TabIndex = 8;
            // 
            // btnReinzoomen
            // 
            btnReinzoomen.Location = new Point(524, 336);
            btnReinzoomen.Name = "btnReinzoomen";
            btnReinzoomen.Size = new Size(35, 23);
            btnReinzoomen.TabIndex = 9;
            btnReinzoomen.Text = "+";
            btnReinzoomen.UseVisualStyleBackColor = true;
            // 
            // btnRauszoomen
            // 
            btnRauszoomen.Location = new Point(623, 336);
            btnRauszoomen.Name = "btnRauszoomen";
            btnRauszoomen.Size = new Size(35, 23);
            btnRauszoomen.TabIndex = 10;
            btnRauszoomen.Text = "-";
            btnRauszoomen.UseVisualStyleBackColor = true;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(524, 191);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(134, 72);
            btnDrehen.TabIndex = 11;
            btnDrehen.Text = "Drehen ";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDrehen);
            Controls.Add(btnRauszoomen);
            Controls.Add(btnReinzoomen);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFleache);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(lblUmfang);
            Controls.Add(lblFleache);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBreite;
        private Label lblHoehe;
        private Label lblFleache;
        private Label lblUmfang;
        private TextBox tbxBreite;
        private TextBox tbxHoehe;
        private TextBox tbxFleache;
        private TextBox tbxUmfang;
        private Button btnReinzoomen;
        private Button btnRauszoomen;
        private Button btnDrehen;
    }
}
