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
            lblDiagonale = new Label();
            tbxDiagonale = new TextBox();
            SuspendLayout();
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(93, 133);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(55, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite :";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(93, 208);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(60, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Hoehe :";
            // 
            // lblFleache
            // 
            lblFleache.AutoSize = true;
            lblFleache.Location = new Point(93, 331);
            lblFleache.Name = "lblFleache";
            lblFleache.Size = new Size(66, 20);
            lblFleache.TabIndex = 3;
            lblFleache.Text = "Flaeche :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(93, 405);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(69, 20);
            lblUmfang.TabIndex = 4;
            lblUmfang.Text = "Umfang :";
            // 
            // tbxBreite
            // 
            tbxBreite.BackColor = SystemColors.ScrollBar;
            tbxBreite.ForeColor = SystemColors.ScrollBar;
            tbxBreite.Location = new Point(256, 123);
            tbxBreite.Margin = new Padding(3, 4, 3, 4);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(114, 27);
            tbxBreite.TabIndex = 5;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // tbxHoehe
            // 
            tbxHoehe.BackColor = SystemColors.ScrollBar;
            tbxHoehe.ForeColor = SystemColors.ScrollBar;
            tbxHoehe.Location = new Point(256, 197);
            tbxHoehe.Margin = new Padding(3, 4, 3, 4);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(114, 27);
            tbxHoehe.TabIndex = 6;
            // 
            // tbxFleache
            // 
            tbxFleache.BackColor = SystemColors.ScrollBar;
            tbxFleache.ForeColor = SystemColors.ScrollBar;
            tbxFleache.Location = new Point(256, 320);
            tbxFleache.Margin = new Padding(3, 4, 3, 4);
            tbxFleache.Name = "tbxFleache";
            tbxFleache.ReadOnly = true;
            tbxFleache.Size = new Size(114, 27);
            tbxFleache.TabIndex = 7;
            // 
            // tbxUmfang
            // 
            tbxUmfang.BackColor = SystemColors.ScrollBar;
            tbxUmfang.ForeColor = SystemColors.ScrollBar;
            tbxUmfang.Location = new Point(256, 405);
            tbxUmfang.Margin = new Padding(3, 4, 3, 4);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(114, 27);
            tbxUmfang.TabIndex = 8;
            // 
            // btnReinzoomen
            // 
            btnReinzoomen.Location = new Point(586, 519);
            btnReinzoomen.Margin = new Padding(3, 4, 3, 4);
            btnReinzoomen.Name = "btnReinzoomen";
            btnReinzoomen.Size = new Size(40, 31);
            btnReinzoomen.TabIndex = 9;
            btnReinzoomen.Text = "+";
            btnReinzoomen.UseVisualStyleBackColor = true;
            // 
            // btnRauszoomen
            // 
            btnRauszoomen.Location = new Point(688, 519);
            btnRauszoomen.Margin = new Padding(3, 4, 3, 4);
            btnRauszoomen.Name = "btnRauszoomen";
            btnRauszoomen.Size = new Size(40, 31);
            btnRauszoomen.TabIndex = 10;
            btnRauszoomen.Text = "-";
            btnRauszoomen.UseVisualStyleBackColor = true;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(586, 401);
            btnDrehen.Margin = new Padding(3, 4, 3, 4);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(142, 96);
            btnDrehen.TabIndex = 11;
            btnDrehen.Text = "Drehen ";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // lblDiagonale
            // 
            lblDiagonale.AutoSize = true;
            lblDiagonale.Location = new Point(93, 477);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(81, 20);
            lblDiagonale.TabIndex = 13;
            lblDiagonale.Text = "Diagonale:";
            // 
            // tbxDiagonale
            // 
            tbxDiagonale.BackColor = SystemColors.ScrollBar;
            tbxDiagonale.ForeColor = SystemColors.ScrollBar;
            tbxDiagonale.Location = new Point(256, 470);
            tbxDiagonale.Margin = new Padding(3, 4, 3, 4);
            tbxDiagonale.Name = "tbxDiagonale";
            tbxDiagonale.ReadOnly = true;
            tbxDiagonale.Size = new Size(114, 27);
            tbxDiagonale.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tbxDiagonale);
            Controls.Add(lblDiagonale);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblDiagonale;
        private TextBox tbxDiagonale;
    }
}
