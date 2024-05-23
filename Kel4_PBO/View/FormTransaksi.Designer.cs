namespace Kel4_PBO.View
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panelContent = new Panel();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            labelChildForm = new Label();
            iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            iconButtonExit = new FontAwesome.Sharp.IconButton();
            btnHome = new PictureBox();
            labelHome = new Label();
            panelHeader = new Panel();
            panel1 = new Panel();
            iconButtonTransaksi = new FontAwesome.Sharp.IconButton();
            iconButtonDataBarang = new FontAwesome.Sharp.IconButton();
            iconButtonKotakMasuk = new FontAwesome.Sharp.IconButton();
            iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            panelLogo = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(344, 200);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "transaksi";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(35, 35, 35);
            panelContent.Controls.Add(dataGridView2);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(textBox4);
            panelContent.Controls.Add(button1);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(textBox3);
            panelContent.Controls.Add(textBox2);
            panelContent.Controls.Add(textBox1);
            panelContent.Controls.Add(comboBox1);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(270, 85);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(932, 445);
            panelContent.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 23);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(852, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelChildForm
            // 
            labelChildForm.AutoSize = true;
            labelChildForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChildForm.ForeColor = Color.White;
            labelChildForm.Location = new Point(42, 46);
            labelChildForm.Name = "labelChildForm";
            labelChildForm.Size = new Size(149, 21);
            labelChildForm.TabIndex = 3;
            labelChildForm.Text = "Transaksi Karyawan";
            labelChildForm.Click += labelChildForm_Click;
            // 
            // iconButtonMinimize
            // 
            iconButtonMinimize.FlatAppearance.BorderSize = 0;
            iconButtonMinimize.FlatStyle = FlatStyle.Flat;
            iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButtonMinimize.IconColor = Color.Black;
            iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMinimize.Location = new Point(680, 7);
            iconButtonMinimize.Name = "iconButtonMinimize";
            iconButtonMinimize.Padding = new Padding(0, 0, 0, 20);
            iconButtonMinimize.Size = new Size(15, 15);
            iconButtonMinimize.TabIndex = 1;
            iconButtonMinimize.UseVisualStyleBackColor = true;
            // 
            // iconButtonExit
            // 
            iconButtonExit.FlatAppearance.BorderSize = 0;
            iconButtonExit.FlatStyle = FlatStyle.Flat;
            iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonExit.IconColor = Color.Black;
            iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonExit.Location = new Point(709, 7);
            iconButtonExit.Name = "iconButtonExit";
            iconButtonExit.Size = new Size(20, 20);
            iconButtonExit.TabIndex = 0;
            iconButtonExit.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.logo;
            btnHome.Location = new Point(62, 69);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(52, 39);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 4;
            btnHome.TabStop = false;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(120, 76);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(73, 32);
            labelHome.TabIndex = 3;
            labelHome.Text = "KINK";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(35, 35, 35);
            panelHeader.Controls.Add(labelChildForm);
            panelHeader.Controls.Add(iconButtonMinimize);
            panelHeader.Controls.Add(iconButtonExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(270, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(932, 85);
            panelHeader.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(267, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 188);
            panel1.TabIndex = 1;
            // 
            // iconButtonTransaksi
            // 
            iconButtonTransaksi.Dock = DockStyle.Top;
            iconButtonTransaksi.FlatAppearance.BorderSize = 0;
            iconButtonTransaksi.FlatStyle = FlatStyle.Flat;
            iconButtonTransaksi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonTransaksi.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonTransaksi.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconButtonTransaksi.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonTransaksi.IconSize = 35;
            iconButtonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonTransaksi.Location = new Point(0, 340);
            iconButtonTransaksi.Name = "iconButtonTransaksi";
            iconButtonTransaksi.Padding = new Padding(30, 0, 0, 0);
            iconButtonTransaksi.Size = new Size(270, 60);
            iconButtonTransaksi.TabIndex = 4;
            iconButtonTransaksi.Text = "Transaksi";
            iconButtonTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonTransaksi.UseVisualStyleBackColor = true;
            // 
            // iconButtonDataBarang
            // 
            iconButtonDataBarang.Dock = DockStyle.Top;
            iconButtonDataBarang.FlatAppearance.BorderSize = 0;
            iconButtonDataBarang.FlatStyle = FlatStyle.Flat;
            iconButtonDataBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDataBarang.ForeColor = Color.Gray;
            iconButtonDataBarang.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            iconButtonDataBarang.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDataBarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDataBarang.IconSize = 35;
            iconButtonDataBarang.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.Location = new Point(0, 280);
            iconButtonDataBarang.Name = "iconButtonDataBarang";
            iconButtonDataBarang.Padding = new Padding(30, 0, 0, 0);
            iconButtonDataBarang.Size = new Size(270, 60);
            iconButtonDataBarang.TabIndex = 3;
            iconButtonDataBarang.Text = "Data Barang";
            iconButtonDataBarang.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDataBarang.UseVisualStyleBackColor = true;
            // 
            // iconButtonKotakMasuk
            // 
            iconButtonKotakMasuk.Dock = DockStyle.Top;
            iconButtonKotakMasuk.FlatAppearance.BorderSize = 0;
            iconButtonKotakMasuk.FlatStyle = FlatStyle.Flat;
            iconButtonKotakMasuk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonKotakMasuk.ForeColor = Color.Gray;
            iconButtonKotakMasuk.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            iconButtonKotakMasuk.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonKotakMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKotakMasuk.IconSize = 35;
            iconButtonKotakMasuk.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKotakMasuk.Location = new Point(0, 220);
            iconButtonKotakMasuk.Name = "iconButtonKotakMasuk";
            iconButtonKotakMasuk.Padding = new Padding(30, 0, 0, 0);
            iconButtonKotakMasuk.Size = new Size(270, 60);
            iconButtonKotakMasuk.TabIndex = 2;
            iconButtonKotakMasuk.Text = "Kotak Masuk";
            iconButtonKotakMasuk.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonKotakMasuk.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonKotakMasuk.UseVisualStyleBackColor = true;
            // 
            // iconButtonDashboard
            // 
            iconButtonDashboard.Dock = DockStyle.Top;
            iconButtonDashboard.FlatAppearance.BorderSize = 0;
            iconButtonDashboard.FlatStyle = FlatStyle.Flat;
            iconButtonDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDashboard.ForeColor = Color.DimGray;
            iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconButtonDashboard.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDashboard.IconSize = 35;
            iconButtonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDashboard.Location = new Point(0, 160);
            iconButtonDashboard.Name = "iconButtonDashboard";
            iconButtonDashboard.Padding = new Padding(30, 0, 0, 0);
            iconButtonDashboard.Size = new Size(270, 60);
            iconButtonDashboard.TabIndex = 1;
            iconButtonDashboard.Text = "Dashboard";
            iconButtonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDashboard.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(iconButtonTransaksi);
            panelMenu.Controls.Add(iconButtonDataBarang);
            panelMenu.Controls.Add(iconButtonKotakMasuk);
            panelMenu.Controls.Add(iconButtonDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(270, 530);
            panelMenu.TabIndex = 3;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(btnHome);
            panelLogo.Controls.Add(labelHome);
            panelLogo.Controls.Add(panel1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(270, 160);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 280);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(159, 306);
            button1.Name = "button1";
            button1.Size = new Size(58, 26);
            button1.TabIndex = 4;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(483, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 23);
            textBox4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 118);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(370, 145);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 4;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1202, 530);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Controls.Add(label1);
            Name = "FormTransaksi";
            Text = "Transaksi";
            Load += FormTransaksi_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelContent;
        private Label labelChildForm;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private PictureBox btnHome;
        private Label labelHome;
        private Panel panelHeader;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonTransaksi;
        private FontAwesome.Sharp.IconButton iconButtonDataBarang;
        private FontAwesome.Sharp.IconButton iconButtonKotakMasuk;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private Panel panelMenu;
        private Panel panelLogo;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox4;
        private DataGridView dataGridView2;
    }
}