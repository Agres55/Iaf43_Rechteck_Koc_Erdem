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
            tbxText = new TextBox();
            lblText = new Label();
            SuspendLayout();
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(93, 33);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(55, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite :";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(93, 89);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(60, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Hoehe :";
            // 
            // lblFleache
            // 
            lblFleache.AutoSize = true;
            lblFleache.Location = new Point(93, 249);
            lblFleache.Name = "lblFleache";
            lblFleache.Size = new Size(66, 20);
            lblFleache.TabIndex = 3;
            lblFleache.Text = "Flaeche :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(93, 320);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(69, 20);
            lblUmfang.TabIndex = 4;
            lblUmfang.Text = "Umfang :";
            // 
            // btnReinzoomen
            // 
            btnReinzoomen.Location = new Point(93, 607);
            btnReinzoomen.Margin = new Padding(3, 4, 3, 4);
            btnReinzoomen.Name = "btnReinzoomen";
            btnReinzoomen.Size = new Size(103, 31);
            btnReinzoomen.TabIndex = 9;
            btnReinzoomen.Text = "+";
            btnReinzoomen.UseVisualStyleBackColor = true;
            btnReinzoomen.Click += btnReinzoomen_Click;
            // 
            // btnRauszoomen
            // 
            btnRauszoomen.Location = new Point(262, 607);
            btnRauszoomen.Margin = new Padding(3, 4, 3, 4);
            btnRauszoomen.Name = "btnRauszoomen";
            btnRauszoomen.Size = new Size(95, 31);
            btnRauszoomen.TabIndex = 10;
            btnRauszoomen.Text = "-";
            btnRauszoomen.UseVisualStyleBackColor = true;
            btnRauszoomen.Click += btnRauszoomen_Click;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(93, 499);
            btnDrehen.Margin = new Padding(3, 4, 3, 4);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(264, 69);
            btnDrehen.TabIndex = 11;
            btnDrehen.Text = "Drehen ";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // lblDiagonale
            // 
            lblDiagonale.AutoSize = true;
            lblDiagonale.Location = new Point(93, 385);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(81, 20);
            lblDiagonale.TabIndex = 13;
            lblDiagonale.Text = "Diagonale:";
            // 
            // lblFarben
            // 
            lblFarben.AutoSize = true;
            lblFarben.Location = new Point(93, 715);
            lblFarben.Name = "lblFarben";
            lblFarben.Size = new Size(56, 20);
            lblFarben.TabIndex = 15;
            lblFarben.Text = "Farben:";
            // 
            // cmbFarben
            // 
            cmbFarben.FormattingEnabled = true;
            cmbFarben.Items.AddRange(new object[] { "Schwarz", "Blau ", "Rot", "Gelb", "Weiß" });
            cmbFarben.Location = new Point(218, 715);
            cmbFarben.Margin = new Padding(3, 4, 3, 4);
            cmbFarben.Name = "cmbFarben";
            cmbFarben.Size = new Size(138, 28);
            cmbFarben.TabIndex = 16;
            cmbFarben.SelectedIndexChanged += cmbFarben_SelectedIndexChanged;
            // 
            // btnRechteck
            // 
            btnRechteck.Location = new Point(815, 75);
            btnRechteck.Margin = new Padding(3, 4, 3, 4);
            btnRechteck.Name = "btnRechteck";
            btnRechteck.Size = new Size(259, 305);
            btnRechteck.TabIndex = 17;
            btnRechteck.UseVisualStyleBackColor = true;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(247, 29);
            tbxBreite.Margin = new Padding(3, 4, 3, 4);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(114, 27);
            tbxBreite.TabIndex = 18;
            tbxBreite.TextChanged += tbxBreite_TextChanged_1;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(247, 85);
            tbxHoehe.Margin = new Padding(3, 4, 3, 4);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(114, 27);
            tbxHoehe.TabIndex = 19;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(247, 245);
            tbxFlaeche.Margin = new Padding(3, 4, 3, 4);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.ReadOnly = true;
            tbxFlaeche.Size = new Size(114, 27);
            tbxFlaeche.TabIndex = 20;

            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(247, 320);
            tbxUmfang.Margin = new Padding(3, 4, 3, 4);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(114, 27);
            tbxUmfang.TabIndex = 21;
            // 
            // tbxDiagonale
            // 
            tbxDiagonale.Location = new Point(247, 385);
            tbxDiagonale.Margin = new Padding(3, 4, 3, 4);
            tbxDiagonale.Name = "tbxDiagonale";
            tbxDiagonale.ReadOnly = true;
            tbxDiagonale.Size = new Size(114, 27);
            tbxDiagonale.TabIndex = 22;
            // 
            // tbxText
            // 
            tbxText.CharacterCasing = CharacterCasing.Upper;
            tbxText.Location = new Point(218, 665);
            tbxText.Name = "tbxText";
            tbxText.Size = new Size(138, 27);
            tbxText.TabIndex = 23;
            tbxText.TextChanged += tbxText_TextChanged;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(93, 668);
            lblText.Name = "lblText";
            lblText.Size = new Size(39, 20);
            lblText.TabIndex = 24;
            lblText.Text = "Text:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 965);
            Controls.Add(lblText);
            Controls.Add(tbxText);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox tbxText;
        private Label lblText;
    }
}
