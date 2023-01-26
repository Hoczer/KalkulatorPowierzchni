namespace KalkulatorPowierzchni
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PowierzchniaPage = new System.Windows.Forms.TabPage();
            this.PowierzchniaLiczButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mnoznikTextBoxPo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szerokoscTextBoxPo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wysokoscTextBoxPo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfilPage = new System.Windows.Forms.TabPage();
            this.liczButtPr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dlugoscPrTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.scianka2TBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.scianka1TBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3m = new System.Windows.Forms.RadioButton();
            this.radioButton2cm = new System.Windows.Forms.RadioButton();
            this.radioButton1mm = new System.Windows.Forms.RadioButton();
            this.RuraPage = new System.Windows.Forms.TabPage();
            this.ruraLiczButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dlugoscTboxRura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.srednicaTBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.wynikTextBoxPo = new System.Windows.Forms.TextBox();
            this.wynikTextBoxPR = new System.Windows.Forms.TextBox();
            this.wynikTextBoxRura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PowierzchniaPage.SuspendLayout();
            this.ProfilPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RuraPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PowierzchniaPage);
            this.tabControl1.Controls.Add(this.ProfilPage);
            this.tabControl1.Controls.Add(this.RuraPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 364);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // PowierzchniaPage
            // 
            this.PowierzchniaPage.BackColor = System.Drawing.Color.DimGray;
            this.PowierzchniaPage.Controls.Add(this.wynikTextBoxPo);
            this.PowierzchniaPage.Controls.Add(this.PowierzchniaLiczButt);
            this.PowierzchniaPage.Controls.Add(this.label4);
            this.PowierzchniaPage.Controls.Add(this.mnoznikTextBoxPo);
            this.PowierzchniaPage.Controls.Add(this.label3);
            this.PowierzchniaPage.Controls.Add(this.szerokoscTextBoxPo);
            this.PowierzchniaPage.Controls.Add(this.label2);
            this.PowierzchniaPage.Controls.Add(this.wysokoscTextBoxPo);
            this.PowierzchniaPage.Controls.Add(this.label1);
            this.PowierzchniaPage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PowierzchniaPage.Location = new System.Drawing.Point(4, 24);
            this.PowierzchniaPage.Name = "PowierzchniaPage";
            this.PowierzchniaPage.Padding = new System.Windows.Forms.Padding(3);
            this.PowierzchniaPage.Size = new System.Drawing.Size(468, 332);
            this.PowierzchniaPage.TabIndex = 0;
            this.PowierzchniaPage.Text = "Powierzchnia";
            // 
            // PowierzchniaLiczButt
            // 
            this.PowierzchniaLiczButt.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PowierzchniaLiczButt.Location = new System.Drawing.Point(134, 265);
            this.PowierzchniaLiczButt.Name = "PowierzchniaLiczButt";
            this.PowierzchniaLiczButt.Size = new System.Drawing.Size(207, 44);
            this.PowierzchniaLiczButt.TabIndex = 9;
            this.PowierzchniaLiczButt.Text = "Licz";
            this.PowierzchniaLiczButt.UseVisualStyleBackColor = true;
            this.PowierzchniaLiczButt.Click += new System.EventHandler(this.PowierzchniaLiczButt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wynik:";
            // 
            // mnoznikTextBoxPo
            // 
            this.mnoznikTextBoxPo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mnoznikTextBoxPo.Location = new System.Drawing.Point(209, 137);
            this.mnoznikTextBoxPo.Name = "mnoznikTextBoxPo";
            this.mnoznikTextBoxPo.Size = new System.Drawing.Size(164, 34);
            this.mnoznikTextBoxPo.TabIndex = 6;
            this.mnoznikTextBoxPo.Text = "1";
            this.mnoznikTextBoxPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mnożnik:";
            // 
            // szerokoscTextBoxPo
            // 
            this.szerokoscTextBoxPo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szerokoscTextBoxPo.Location = new System.Drawing.Point(209, 83);
            this.szerokoscTextBoxPo.Name = "szerokoscTextBoxPo";
            this.szerokoscTextBoxPo.Size = new System.Drawing.Size(164, 34);
            this.szerokoscTextBoxPo.TabIndex = 4;
            this.szerokoscTextBoxPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerokość:";
            // 
            // wysokoscTextBoxPo
            // 
            this.wysokoscTextBoxPo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wysokoscTextBoxPo.Location = new System.Drawing.Point(209, 27);
            this.wysokoscTextBoxPo.Name = "wysokoscTextBoxPo";
            this.wysokoscTextBoxPo.Size = new System.Drawing.Size(164, 34);
            this.wysokoscTextBoxPo.TabIndex = 1;
            this.wysokoscTextBoxPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wysokość:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProfilPage
            // 
            this.ProfilPage.BackColor = System.Drawing.Color.DimGray;
            this.ProfilPage.Controls.Add(this.wynikTextBoxPR);
            this.ProfilPage.Controls.Add(this.liczButtPr);
            this.ProfilPage.Controls.Add(this.label6);
            this.ProfilPage.Controls.Add(this.dlugoscPrTBox);
            this.ProfilPage.Controls.Add(this.label7);
            this.ProfilPage.Controls.Add(this.scianka2TBox);
            this.ProfilPage.Controls.Add(this.label8);
            this.ProfilPage.Controls.Add(this.scianka1TBox);
            this.ProfilPage.Controls.Add(this.label9);
            this.ProfilPage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProfilPage.Location = new System.Drawing.Point(4, 24);
            this.ProfilPage.Name = "ProfilPage";
            this.ProfilPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilPage.Size = new System.Drawing.Size(468, 336);
            this.ProfilPage.TabIndex = 1;
            this.ProfilPage.Text = "Profil/Kątownik";
            // 
            // liczButtPr
            // 
            this.liczButtPr.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczButtPr.Location = new System.Drawing.Point(144, 264);
            this.liczButtPr.Name = "liczButtPr";
            this.liczButtPr.Size = new System.Drawing.Size(207, 44);
            this.liczButtPr.TabIndex = 18;
            this.liczButtPr.Text = "Licz";
            this.liczButtPr.UseVisualStyleBackColor = true;
            this.liczButtPr.Click += new System.EventHandler(this.liczButtPr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wynik:";
            // 
            // dlugoscPrTBox
            // 
            this.dlugoscPrTBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlugoscPrTBox.Location = new System.Drawing.Point(219, 136);
            this.dlugoscPrTBox.Name = "dlugoscPrTBox";
            this.dlugoscPrTBox.Size = new System.Drawing.Size(164, 34);
            this.dlugoscPrTBox.TabIndex = 15;
            this.dlugoscPrTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(107, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Długość:";
            // 
            // scianka2TBox
            // 
            this.scianka2TBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scianka2TBox.Location = new System.Drawing.Point(219, 82);
            this.scianka2TBox.Name = "scianka2TBox";
            this.scianka2TBox.Size = new System.Drawing.Size(164, 34);
            this.scianka2TBox.TabIndex = 13;
            this.scianka2TBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(132, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bok 2:";
            // 
            // scianka1TBox
            // 
            this.scianka1TBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scianka1TBox.Location = new System.Drawing.Point(219, 26);
            this.scianka1TBox.Name = "scianka1TBox";
            this.scianka1TBox.Size = new System.Drawing.Size(164, 34);
            this.scianka1TBox.TabIndex = 11;
            this.scianka1TBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(132, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bok 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.radioButton3m);
            this.groupBox1.Controls.Add(this.radioButton2cm);
            this.groupBox1.Controls.Add(this.radioButton1mm);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jednostki";
            // 
            // radioButton3m
            // 
            this.radioButton3m.AutoSize = true;
            this.radioButton3m.Location = new System.Drawing.Point(189, 24);
            this.radioButton3m.Name = "radioButton3m";
            this.radioButton3m.Size = new System.Drawing.Size(38, 21);
            this.radioButton3m.TabIndex = 2;
            this.radioButton3m.Text = "m";
            this.radioButton3m.UseVisualStyleBackColor = true;
            // 
            // radioButton2cm
            // 
            this.radioButton2cm.AutoSize = true;
            this.radioButton2cm.Checked = true;
            this.radioButton2cm.Location = new System.Drawing.Point(107, 24);
            this.radioButton2cm.Name = "radioButton2cm";
            this.radioButton2cm.Size = new System.Drawing.Size(46, 21);
            this.radioButton2cm.TabIndex = 1;
            this.radioButton2cm.TabStop = true;
            this.radioButton2cm.Text = "cm";
            this.radioButton2cm.UseVisualStyleBackColor = true;
            // 
            // radioButton1mm
            // 
            this.radioButton1mm.AutoSize = true;
            this.radioButton1mm.Location = new System.Drawing.Point(21, 24);
            this.radioButton1mm.Name = "radioButton1mm";
            this.radioButton1mm.Size = new System.Drawing.Size(50, 21);
            this.radioButton1mm.TabIndex = 0;
            this.radioButton1mm.Text = "mm";
            this.radioButton1mm.UseVisualStyleBackColor = true;
            // 
            // RuraPage
            // 
            this.RuraPage.BackColor = System.Drawing.Color.DimGray;
            this.RuraPage.Controls.Add(this.wynikTextBoxRura);
            this.RuraPage.Controls.Add(this.ruraLiczButton);
            this.RuraPage.Controls.Add(this.label10);
            this.RuraPage.Controls.Add(this.dlugoscTboxRura);
            this.RuraPage.Controls.Add(this.label11);
            this.RuraPage.Controls.Add(this.srednicaTBox);
            this.RuraPage.Controls.Add(this.label13);
            this.RuraPage.Location = new System.Drawing.Point(4, 24);
            this.RuraPage.Name = "RuraPage";
            this.RuraPage.Size = new System.Drawing.Size(468, 332);
            this.RuraPage.TabIndex = 2;
            this.RuraPage.Text = "Rura";
            // 
            // ruraLiczButton
            // 
            this.ruraLiczButton.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ruraLiczButton.Location = new System.Drawing.Point(134, 263);
            this.ruraLiczButton.Name = "ruraLiczButton";
            this.ruraLiczButton.Size = new System.Drawing.Size(207, 44);
            this.ruraLiczButton.TabIndex = 27;
            this.ruraLiczButton.Text = "Licz";
            this.ruraLiczButton.UseVisualStyleBackColor = true;
            this.ruraLiczButton.Click += new System.EventHandler(this.ruraLiczButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 38);
            this.label10.TabIndex = 25;
            this.label10.Text = "Wynik:";
            // 
            // dlugoscTboxRura
            // 
            this.dlugoscTboxRura.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlugoscTboxRura.Location = new System.Drawing.Point(209, 135);
            this.dlugoscTboxRura.Name = "dlugoscTboxRura";
            this.dlugoscTboxRura.Size = new System.Drawing.Size(164, 34);
            this.dlugoscTboxRura.TabIndex = 24;
            this.dlugoscTboxRura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(97, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "Długość:";
            // 
            // srednicaTBox
            // 
            this.srednicaTBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.srednicaTBox.Location = new System.Drawing.Point(209, 86);
            this.srednicaTBox.Name = "srednicaTBox";
            this.srednicaTBox.Size = new System.Drawing.Size(164, 34);
            this.srednicaTBox.TabIndex = 20;
            this.srednicaTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(89, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 19;
            this.label13.Text = "Średnica:";
            // 
            // wynikTextBoxPo
            // 
            this.wynikTextBoxPo.BackColor = System.Drawing.Color.DimGray;
            this.wynikTextBoxPo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynikTextBoxPo.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikTextBoxPo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wynikTextBoxPo.Location = new System.Drawing.Point(221, 192);
            this.wynikTextBoxPo.Name = "wynikTextBoxPo";
            this.wynikTextBoxPo.ReadOnly = true;
            this.wynikTextBoxPo.Size = new System.Drawing.Size(152, 39);
            this.wynikTextBoxPo.TabIndex = 10;
            this.wynikTextBoxPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wynikTextBoxPR
            // 
            this.wynikTextBoxPR.BackColor = System.Drawing.Color.DimGray;
            this.wynikTextBoxPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynikTextBoxPR.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikTextBoxPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wynikTextBoxPR.Location = new System.Drawing.Point(226, 191);
            this.wynikTextBoxPR.Name = "wynikTextBoxPR";
            this.wynikTextBoxPR.ReadOnly = true;
            this.wynikTextBoxPR.Size = new System.Drawing.Size(152, 39);
            this.wynikTextBoxPR.TabIndex = 19;
            this.wynikTextBoxPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wynikTextBoxRura
            // 
            this.wynikTextBoxRura.BackColor = System.Drawing.Color.DimGray;
            this.wynikTextBoxRura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynikTextBoxRura.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikTextBoxRura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wynikTextBoxRura.Location = new System.Drawing.Point(216, 189);
            this.wynikTextBoxRura.Name = "wynikTextBoxRura";
            this.wynikTextBoxRura.ReadOnly = true;
            this.wynikTextBoxRura.Size = new System.Drawing.Size(152, 39);
            this.wynikTextBoxRura.TabIndex = 28;
            this.wynikTextBoxRura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(278, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Program by Bartosz Orzechowski";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(277, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 37);
            this.label12.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(500, 446);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Powierzchni";
            this.tabControl1.ResumeLayout(false);
            this.PowierzchniaPage.ResumeLayout(false);
            this.PowierzchniaPage.PerformLayout();
            this.ProfilPage.ResumeLayout(false);
            this.ProfilPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RuraPage.ResumeLayout(false);
            this.RuraPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PowierzchniaPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ProfilPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mnoznikTextBoxPo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox szerokoscTextBoxPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wysokoscTextBoxPo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3m;
        private System.Windows.Forms.RadioButton radioButton2cm;
        private System.Windows.Forms.RadioButton radioButton1mm;
        private System.Windows.Forms.Button PowierzchniaLiczButt;
        private System.Windows.Forms.Button liczButtPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dlugoscPrTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox scianka2TBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox scianka1TBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage RuraPage;
        private System.Windows.Forms.Button ruraLiczButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dlugoscTboxRura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox srednicaTBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox wynikTextBoxPo;
        private System.Windows.Forms.TextBox wynikTextBoxPR;
        private System.Windows.Forms.TextBox wynikTextBoxRura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}

