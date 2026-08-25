namespace DustyCover
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel rightPanel;

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.Label emailLabel;

        private System.Windows.Forms.Label phoneLabel;

        private System.Windows.Forms.Button historyButton;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.borrowingTitle = new System.Windows.Forms.Label();
            this.readsTitle = new System.Windows.Forms.Label();
            this.borrowingValue = new System.Windows.Forms.Label();
            this.readsValue = new System.Windows.Forms.Label();
            this.paymentTitle = new System.Windows.Forms.Label();
            this.paymentValue = new System.Windows.Forms.Label();
            this.booksTitle = new System.Windows.Forms.Label();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.emaitextBox1 = new System.Windows.Forms.TextBox();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(56)))), ((int)(((byte)(32)))));
            this.rightPanel.Controls.Add(this.panel2);
            this.rightPanel.Controls.Add(this.userNameLabel);
            this.rightPanel.Controls.Add(this.welcomeLabel);
            this.rightPanel.Controls.Add(this.logoutButton);
            this.rightPanel.Controls.Add(this.emailLabel);
            this.rightPanel.Controls.Add(this.phoneLabel);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Controls.Add(this.panel3);
            this.rightPanel.Controls.Add(this.panel4);
            this.rightPanel.Location = new System.Drawing.Point(491, -2);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(481, 619);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(52, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 35);
            this.panel2.TabIndex = 13;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(3, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 31);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userNameLabel.Location = new System.Drawing.Point(42, 16);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(181, 38);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.welcomeLabel.Location = new System.Drawing.Point(48, 55);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(339, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome, @user to your user account page!";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.logoutButton.Location = new System.Drawing.Point(309, 13);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 36);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "↪ Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.emailLabel.Location = new System.Drawing.Point(47, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(106, 31);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-Mail";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.phoneLabel.Location = new System.Drawing.Point(51, 226);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(149, 31);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emaitextBox1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(53, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 35);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 28);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.historyButton);
            this.panel3.Location = new System.Drawing.Point(70, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 32);
            this.panel3.TabIndex = 17;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.historyButton.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.historyButton.Location = new System.Drawing.Point(-2, -2);
            this.historyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(345, 32);
            this.historyButton.TabIndex = 9;
            this.historyButton.Text = "Borrowing / History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.editButton);
            this.panel4.Location = new System.Drawing.Point(166, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 30);
            this.panel4.TabIndex = 18;
           // this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(238)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editButton.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.editButton.Location = new System.Drawing.Point(-2, -2);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(156, 30);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // borrowingTitle
            // 
            this.borrowingTitle.AutoSize = true;
            this.borrowingTitle.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Bold);
            this.borrowingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.borrowingTitle.Location = new System.Drawing.Point(108, 27);
            this.borrowingTitle.Name = "borrowingTitle";
            this.borrowingTitle.Size = new System.Drawing.Size(175, 34);
            this.borrowingTitle.TabIndex = 1;
            this.borrowingTitle.Text = "Borrowing";
            // 
            // readsTitle
            // 
            this.readsTitle.AutoSize = true;
            this.readsTitle.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Bold);
            this.readsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.readsTitle.Location = new System.Drawing.Point(108, 113);
            this.readsTitle.Name = "readsTitle";
            this.readsTitle.Size = new System.Drawing.Size(190, 34);
            this.readsTitle.TabIndex = 1;
            this.readsTitle.Text = "Total Reads";
            // 
            // borrowingValue
            // 
            this.borrowingValue.AutoSize = true;
            this.borrowingValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.borrowingValue.Location = new System.Drawing.Point(392, 30);
            this.borrowingValue.Name = "borrowingValue";
            this.borrowingValue.Size = new System.Drawing.Size(48, 31);
            this.borrowingValue.TabIndex = 2;
            this.borrowingValue.Text = "07";
            this.borrowingValue.Click += new System.EventHandler(this.borrowingValue_Click);
            // 
            // readsValue
            // 
            this.readsValue.AutoSize = true;
            this.readsValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.readsValue.Location = new System.Drawing.Point(391, 113);
            this.readsValue.Name = "readsValue";
            this.readsValue.Size = new System.Drawing.Size(49, 31);
            this.readsValue.TabIndex = 2;
            this.readsValue.Text = "24";
            // 
            // paymentTitle
            // 
            this.paymentTitle.AutoSize = true;
            this.paymentTitle.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.paymentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.paymentTitle.Location = new System.Drawing.Point(108, 195);
            this.paymentTitle.Name = "paymentTitle";
            this.paymentTitle.Size = new System.Drawing.Size(199, 31);
            this.paymentTitle.TabIndex = 1;
            this.paymentTitle.Text = "Payment Due";
            // 
            // paymentValue
            // 
            this.paymentValue.AutoSize = true;
            this.paymentValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.paymentValue.Location = new System.Drawing.Point(360, 196);
            this.paymentValue.Name = "paymentValue";
            this.paymentValue.Size = new System.Drawing.Size(111, 31);
            this.paymentValue.TabIndex = 2;
            this.paymentValue.Text = "$35.00";
            // 
            // booksTitle
            // 
            this.booksTitle.AutoSize = true;
            this.booksTitle.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.booksTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.booksTitle.Location = new System.Drawing.Point(32, 256);
            this.booksTitle.Name = "booksTitle";
            this.booksTitle.Size = new System.Drawing.Size(360, 30);
            this.booksTitle.TabIndex = 0;
            this.booksTitle.Text = "Currently Borrowed Books";
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.AllowUserToResizeRows = false;
            this.booksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.booksGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.booksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.booksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.booksGrid.ColumnHeadersHeight = 38;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.ReturnDue});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.booksGrid.EnableHeadersVisualStyles = false;
            this.booksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.booksGrid.Location = new System.Drawing.Point(21, 301);
            this.booksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowHeadersWidth = 51;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(450, 296);
            this.booksGrid.TabIndex = 1;
            this.booksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGrid_CellContentClick);
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 205;
            // 
            // ReturnDue
            // 
            this.ReturnDue.HeaderText = "Return Due";
            this.ReturnDue.MinimumWidth = 6;
            this.ReturnDue.Name = "ReturnDue";
            this.ReturnDue.ReadOnly = true;
            this.ReturnDue.Width = 155;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.iconButton6);
            this.leftPanel.Controls.Add(this.iconButton5);
            this.leftPanel.Controls.Add(this.booksGrid);
            this.leftPanel.Controls.Add(this.booksTitle);
            this.leftPanel.Controls.Add(this.paymentValue);
            this.leftPanel.Controls.Add(this.paymentTitle);
            this.leftPanel.Controls.Add(this.readsValue);
            this.leftPanel.Controls.Add(this.borrowingValue);
            this.leftPanel.Controls.Add(this.readsTitle);
            this.leftPanel.Controls.Add(this.borrowingTitle);
            this.leftPanel.Location = new System.Drawing.Point(-5, -2);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(498, 619);
            this.leftPanel.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(16, 113);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(53, 51);
            this.iconButton6.TabIndex = 4;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(21, 24);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(53, 51);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // emaitextBox1
            // 
            this.emaitextBox1.Location = new System.Drawing.Point(57, -1);
            this.emaitextBox1.Multiline = true;
            this.emaitextBox1.Name = "emaitextBox1";
            this.emaitextBox1.Size = new System.Drawing.Size(318, 35);
            this.emaitextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DustyCover - User Account";
//this.Load += new System.EventHandler(this.Form1_Load);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label borrowingTitle;
        private System.Windows.Forms.Label readsTitle;
        private System.Windows.Forms.Label borrowingValue;
        private System.Windows.Forms.Label readsValue;
        private System.Windows.Forms.Label paymentTitle;
        private System.Windows.Forms.Label paymentValue;
        private System.Windows.Forms.Label booksTitle;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDue;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button editButton;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox emaitextBox1;
    }
}