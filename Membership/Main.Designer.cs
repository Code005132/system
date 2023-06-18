namespace Membership
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Sidebar = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            AddMemButton = new Button();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            Dashboard = new Panel();
            pictureBox2 = new PictureBox();
            DashboardButton = new Button();
            menuPannel = new Panel();
            PMenuButton = new PictureBox();
            MenuButton = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            SearchBox = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            normalcount = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            Premuimcount = new Label();
            PMember = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            Delete_btn = new Button();
            search_btn = new Button();
            panel7 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close = new Button();
            Sidebar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PMenuButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.MidnightBlue;
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(Dashboard);
            Sidebar.Controls.Add(menuPannel);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(259, 761);
            Sidebar.MinimumSize = new Size(63, 761);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(259, 761);
            Sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(AddMemButton);
            panel4.Location = new Point(1, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 54);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 46);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // AddMemButton
            // 
            AddMemButton.BackColor = Color.MidnightBlue;
            AddMemButton.FlatAppearance.BorderSize = 0;
            AddMemButton.FlatStyle = FlatStyle.Flat;
            AddMemButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemButton.ForeColor = SystemColors.ButtonFace;
            AddMemButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddMemButton.Location = new Point(-5, 2);
            AddMemButton.Name = "AddMemButton";
            AddMemButton.Size = new Size(263, 49);
            AddMemButton.TabIndex = 0;
            AddMemButton.Text = "       Add Member";
            AddMemButton.TextAlign = ContentAlignment.MiddleLeft;
            AddMemButton.UseVisualStyleBackColor = false;
            AddMemButton.Click += AddMemButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(1, 299);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 54);
            panel5.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 46);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 2);
            button4.Name = "button4";
            button4.Size = new Size(258, 49);
            button4.TabIndex = 0;
            button4.Text = "         Renew";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(128, 128, 255);
            Dashboard.Controls.Add(pictureBox2);
            Dashboard.Controls.Add(DashboardButton);
            Dashboard.Location = new Point(2, 179);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(257, 54);
            Dashboard.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(6, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 46);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.FromArgb(128, 128, 255);
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardButton.ForeColor = SystemColors.ButtonHighlight;
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(0, 2);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(258, 49);
            DashboardButton.TabIndex = 0;
            DashboardButton.Text = "      Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.UseVisualStyleBackColor = false;
            // 
            // menuPannel
            // 
            menuPannel.Controls.Add(PMenuButton);
            menuPannel.Controls.Add(MenuButton);
            menuPannel.Location = new Point(1, 94);
            menuPannel.Name = "menuPannel";
            menuPannel.Size = new Size(257, 54);
            menuPannel.TabIndex = 0;
            // 
            // PMenuButton
            // 
            PMenuButton.BackgroundImage = (Image)resources.GetObject("PMenuButton.BackgroundImage");
            PMenuButton.BackgroundImageLayout = ImageLayout.Stretch;
            PMenuButton.Image = (Image)resources.GetObject("PMenuButton.Image");
            PMenuButton.Location = new Point(7, 5);
            PMenuButton.Name = "PMenuButton";
            PMenuButton.Size = new Size(45, 46);
            PMenuButton.TabIndex = 1;
            PMenuButton.TabStop = false;
            PMenuButton.Click += PMenuButton_Click;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.MidnightBlue;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            MenuButton.ForeColor = SystemColors.ButtonFace;
            MenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            MenuButton.Location = new Point(0, 3);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(238, 49);
            MenuButton.TabIndex = 0;
            MenuButton.Text = "       Menu";
            MenuButton.TextAlign = ContentAlignment.MiddleLeft;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.Location = new Point(279, 162);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(431, 33);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += textBox1_TextChanged;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(770, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 30);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(normalcount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(570, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 66);
            panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(7, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // normalcount
            // 
            normalcount.AutoSize = true;
            normalcount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            normalcount.ForeColor = SystemColors.ControlLightLight;
            normalcount.Location = new Point(173, 12);
            normalcount.Name = "normalcount";
            normalcount.Size = new Size(29, 45);
            normalcount.TabIndex = 1;
            normalcount.Text = "l";
            normalcount.Click += normalcount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 3);
            label1.Name = "label1";
            label1.Size = new Size(136, 60);
            label1.TabIndex = 0;
            label1.Text = "Normal \r\nMambership\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(Premuimcount);
            panel2.Controls.Add(PMember);
            panel2.Location = new Point(836, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 66);
            panel2.TabIndex = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(7, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // Premuimcount
            // 
            Premuimcount.AutoSize = true;
            Premuimcount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Premuimcount.ForeColor = SystemColors.ControlLightLight;
            Premuimcount.Location = new Point(173, 12);
            Premuimcount.Name = "Premuimcount";
            Premuimcount.Size = new Size(29, 45);
            Premuimcount.TabIndex = 1;
            Premuimcount.Text = "l";
            // 
            // PMember
            // 
            PMember.AutoSize = true;
            PMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PMember.Location = new Point(45, 0);
            PMember.Name = "PMember";
            PMember.Size = new Size(136, 90);
            PMember.TabIndex = 0;
            PMember.Text = "Premium\r\nMambership\r\n\r\n";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MidnightBlue;
            panel6.Controls.Add(close);
            panel6.Location = new Point(1, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1085, 42);
            panel6.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 520);
            dataGridView1.TabIndex = 1;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(960, 159);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(118, 32);
            Delete_btn.TabIndex = 6;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(714, 162);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(50, 33);
            search_btn.TabIndex = 7;
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(277, 199);
            panel7.Name = "panel7";
            panel7.Size = new Size(801, 28);
            panel7.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(356, 3);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 0;
            label2.Text = "Members";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(724, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatAppearance.BorderColor = Color.Red;
            close.FlatStyle = FlatStyle.Popup;
            close.ImeMode = ImeMode.NoControl;
            close.Location = new Point(1039, 9);
            close.Name = "close";
            close.Size = new Size(25, 25);
            close.TabIndex = 1;
            close.Text = "x";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 761);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
            Controls.Add(search_btn);
            Controls.Add(Delete_btn);
            Controls.Add(dataGridView1);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(SearchBox);
            Controls.Add(Sidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            Sidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PMenuButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Sidebar;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Button AddMemButton;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Button button4;
        private Panel Dashboard;
        private PictureBox pictureBox2;
        private Button DashboardButton;
        private Panel menuPannel;
        private PictureBox PMenuButton;
        private Button MenuButton;
        private System.Windows.Forms.Timer SidebarTimer;
        private TextBox SearchBox;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Label normalcount;
        private Label label1;
        private Label Premuimcount;
        private Label PMember;
        private DataGridView dataGridView1;
        private Button Delete_btn;
        private Button search_btn;
        private Panel panel7;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button close;
    }
}