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
            btnReinzoomen = new Button();
            btnRauszoomen = new Button();
            btnDrehen = new Button();
            lblDiagonale = new Label();
            lblFarben = new Label();
            cmbFarben = new ComboBox();
            btnRechteck = new Button();
            tbxBreite = new TextBox();
            tbxHoehe = new TextBox();
            tbxFlaeche = new TextBox();
            tbxUmfang = new TextBox();
            tbxDiagonale = new TextBox();
            SuspendLayout();
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(81, 25);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(43, 15);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite :";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(81, 67);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 15);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Hoehe :";
            // 
            // lblFleache
            // 
            lblFleache.AutoSize = true;
            lblFleache.Location = new Point(81, 187);
            lblFleache.Name = "lblFleache";
            lblFleache.Size = new Size(53, 15);
            lblFleache.TabIndex = 3;
            lblFleache.Text = "Flaeche :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(81, 240);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(56, 15);
            lblUmfang.TabIndex = 4;
            lblUmfang.Text = "Umfang :";
            // 
            // btnReinzoomen
            // 
            btnReinzoomen.Location = new Point(81, 455);
            btnReinzoomen.Name = "btnReinzoomen";
            btnReinzoomen.Size = new Size(90, 23);
            btnReinzoomen.TabIndex = 9;
            btnReinzoomen.Text = "+";
            btnReinzoomen.UseVisualStyleBackColor = true;
            btnReinzoomen.Click += btnReinzoomen_Click;
            // 
            // btnRauszoomen
            // 
            btnRauszoomen.Location = new Point(229, 455);
            btnRauszoomen.Name = "btnRauszoomen";
            btnRauszoomen.Size = new Size(83, 23);
            btnRauszoomen.TabIndex = 10;
            btnRauszoomen.Text = "-";
            btnRauszoomen.UseVisualStyleBackColor = true;
            btnRauszoomen.Click += btnRauszoomen_Click;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(81, 374);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(231, 52);
            btnDrehen.TabIndex = 11;
            btnDrehen.Text = "Drehen ";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // lblDiagonale
            // 
            lblDiagonale.AutoSize = true;
            lblDiagonale.Location = new Point(81, 289);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(63, 15);
            lblDiagonale.TabIndex = 13;
            lblDiagonale.Text = "Diagonale:";
            // 
            // lblFarben
            // 
            lblFarben.AutoSize = true;
            lblFarben.Location = new Point(81, 536);
            lblFarben.Name = "lblFarben";
            lblFarben.Size = new Size(46, 15);
            lblFarben.TabIndex = 15;
            lblFarben.Text = "Farben:";
            // 
            // cmbFarben
            // 
            cmbFarben.FormattingEnabled = true;
            cmbFarben.Location = new Point(191, 536);
            cmbFarben.Name = "cmbFarben";
            cmbFarben.Size = new Size(121, 23);
            cmbFarben.TabIndex = 16;
            // 
            // btnRechteck
            // 
            btnRechteck.Location = new Point(713, 56);
            btnRechteck.Name = "btnRechteck";
            btnRechteck.Size = new Size(227, 229);
            btnRechteck.TabIndex = 17;
            btnRechteck.UseVisualStyleBackColor = true;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(216, 22);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(100, 23);
            tbxBreite.TabIndex = 18;
            tbxBreite.TextChanged += tbxBreite_TextChanged_1;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(216, 64);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(100, 23);
            tbxHoehe.TabIndex = 19;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(216, 184);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.ReadOnly = true;
            tbxFlaeche.Size = new Size(100, 23);
            tbxFlaeche.TabIndex = 20;
            tbxFlaeche.TextChanged += tbxFlaeche_TextChanged_1;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(216, 240);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(100, 23);
            tbxUmfang.TabIndex = 21;
            // 
            // tbxDiagonale
            // 
            tbxDiagonale.Location = new Point(216, 289);
            tbxDiagonale.Name = "tbxDiagonale";
            tbxDiagonale.ReadOnly = true;
            tbxDiagonale.Size = new Size(100, 23);
            tbxDiagonale.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 724);
            Controls.Add(tbxDiagonale);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxFlaeche);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(btnRechteck);
            Controls.Add(cmbFarben);
            Controls.Add(lblFarben);
            Controls.Add(lblDiagonale);
            Controls.Add(btnDrehen);
            Controls.Add(btnRauszoomen);
            Controls.Add(btnReinzoomen);
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
        private Button btnReinzoomen;
        private Button btnRauszoomen;
        private Button btnDrehen;
        private Label lblDiagonale;
        private Label lblFarben;
        private ComboBox cmbFarben;
        private Button btnRechteck;
        private TextBox tbxBreite;
        private TextBox tbxHoehe;
        private TextBox tbxFlaeche;
        private TextBox tbxUmfang;
        private TextBox tbxDiagonale;
    }
}
