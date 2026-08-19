namespace DustyCover
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;

        private System.Windows.Forms.Panel borrowingCard;
        private System.Windows.Forms.Panel readsCard;
        private System.Windows.Forms.Panel paymentCard;
        private System.Windows.Forms.Panel booksPanel;

        private System.Windows.Forms.Label borrowingIcon;
        private System.Windows.Forms.Label borrowingTitle;
        private System.Windows.Forms.Label borrowingValue;

        private System.Windows.Forms.Label readsIcon;
        private System.Windows.Forms.Label readsTitle;
        private System.Windows.Forms.Label readsValue;

        private System.Windows.Forms.Label paymentIcon;
        private System.Windows.Forms.Label paymentTitle;
        private System.Windows.Forms.Label paymentValue;

        private System.Windows.Forms.Label booksTitle;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDue;

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Panel emailIconPanel;
        private System.Windows.Forms.Label emailIcon;
        private System.Windows.Forms.TextBox emailTextBox;

        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Panel phoneIconPanel;
        private System.Windows.Forms.Label phoneIcon;
        private System.Windows.Forms.TextBox phoneTextBox;

        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button editButton;


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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.borrowingCard = new System.Windows.Forms.Panel();
            this.borrowingIcon = new System.Windows.Forms.Label();
            this.borrowingTitle = new System.Windows.Forms.Label();
            this.borrowingValue = new System.Windows.Forms.Label();
            this.readsCard = new System.Windows.Forms.Panel();
            this.readsIcon = new System.Windows.Forms.Label();
            this.readsTitle = new System.Windows.Forms.Label();
            this.readsValue = new System.Windows.Forms.Label();
            this.paymentCard = new System.Windows.Forms.Panel();
            this.paymentIcon = new System.Windows.Forms.Label();
            this.paymentTitle = new System.Windows.Forms.Label();
            this.paymentValue = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.booksTitle = new System.Windows.Forms.Label();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailIconPanel = new System.Windows.Forms.Panel();
            this.emailIcon = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneIconPanel = new System.Windows.Forms.Panel();
            this.phoneIcon = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.borrowingCard.SuspendLayout();
            this.readsCard.SuspendLayout();
            this.paymentCard.SuspendLayout();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.emailIconPanel.SuspendLayout();
            this.phoneIconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.borrowingCard);
            this.leftPanel.Controls.Add(this.readsCard);
            this.leftPanel.Controls.Add(this.paymentCard);
            this.leftPanel.Controls.Add(this.booksPanel);
            this.leftPanel.Location = new System.Drawing.Point(-4, -2);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(399, 604);
            this.leftPanel.TabIndex = 0;
            // 
            // borrowingCard
            // 
            this.borrowingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.borrowingCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borrowingCard.Controls.Add(this.borrowingIcon);
            this.borrowingCard.Controls.Add(this.borrowingTitle);
            this.borrowingCard.Controls.Add(this.borrowingValue);
            this.borrowingCard.Location = new System.Drawing.Point(19, 28);
            this.borrowingCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrowingCard.Name = "borrowingCard";
            this.borrowingCard.Size = new System.Drawing.Size(358, 85);
            this.borrowingCard.TabIndex = 0;
            // 
            // borrowingIcon
            // 
            this.borrowingIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            this.borrowingIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 28F);
            this.borrowingIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.borrowingIcon.Location = new System.Drawing.Point(15, 16);
            this.borrowingIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrowingIcon.Name = "borrowingIcon";
            this.borrowingIcon.Size = new System.Drawing.Size(49, 53);
            this.borrowingIcon.TabIndex = 0;
            this.borrowingIcon.Text = "📖";
            this.borrowingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowingTitle
            // 
            this.borrowingTitle.AutoSize = true;
            this.borrowingTitle.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Bold);
            this.borrowingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.borrowingTitle.Location = new System.Drawing.Point(79, 31);
            this.borrowingTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrowingTitle.Name = "borrowingTitle";
            this.borrowingTitle.Size = new System.Drawing.Size(140, 27);
            this.borrowingTitle.TabIndex = 1;
            this.borrowingTitle.Text = "Borrowing";
            // 
            // borrowingValue
            // 
            this.borrowingValue.AutoSize = true;
            this.borrowingValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.borrowingValue.Location = new System.Drawing.Point(303, 31);
            this.borrowingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrowingValue.Name = "borrowingValue";
            this.borrowingValue.Size = new System.Drawing.Size(39, 25);
            this.borrowingValue.TabIndex = 2;
            this.borrowingValue.Text = "07";
            this.borrowingValue.Click += new System.EventHandler(this.borrowingValue_Click);
            // 
            // readsCard
            // 
            this.readsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.readsCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.readsCard.Controls.Add(this.readsIcon);
            this.readsCard.Controls.Add(this.readsTitle);
            this.readsCard.Controls.Add(this.readsValue);
            this.readsCard.Location = new System.Drawing.Point(19, 126);
            this.readsCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readsCard.Name = "readsCard";
            this.readsCard.Size = new System.Drawing.Size(358, 85);
            this.readsCard.TabIndex = 1;
            // 
            // readsIcon
            // 
            this.readsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            this.readsIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 27F);
            this.readsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.readsIcon.Location = new System.Drawing.Point(15, 16);
            this.readsIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readsIcon.Name = "readsIcon";
            this.readsIcon.Size = new System.Drawing.Size(49, 53);
            this.readsIcon.TabIndex = 0;
            this.readsIcon.Text = "📕";
            this.readsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readsTitle
            // 
            this.readsTitle.AutoSize = true;
            this.readsTitle.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Bold);
            this.readsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.readsTitle.Location = new System.Drawing.Point(79, 31);
            this.readsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readsTitle.Name = "readsTitle";
            this.readsTitle.Size = new System.Drawing.Size(152, 27);
            this.readsTitle.TabIndex = 1;
            this.readsTitle.Text = "Total Reads";
            // 
            // readsValue
            // 
            this.readsValue.AutoSize = true;
            this.readsValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.readsValue.Location = new System.Drawing.Point(295, 31);
            this.readsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readsValue.Name = "readsValue";
            this.readsValue.Size = new System.Drawing.Size(39, 25);
            this.readsValue.TabIndex = 2;
            this.readsValue.Text = "24";
            // 
            // paymentCard
            // 
            this.paymentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.paymentCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentCard.Controls.Add(this.paymentIcon);
            this.paymentCard.Controls.Add(this.paymentTitle);
            this.paymentCard.Controls.Add(this.paymentValue);
            this.paymentCard.Location = new System.Drawing.Point(19, 223);
            this.paymentCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paymentCard.Name = "paymentCard";
            this.paymentCard.Size = new System.Drawing.Size(358, 85);
            this.paymentCard.TabIndex = 2;
            // 
            // paymentIcon
            // 
            this.paymentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            this.paymentIcon.Font = new System.Drawing.Font("Georgia", 31F);
            this.paymentIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.paymentIcon.Location = new System.Drawing.Point(15, 16);
            this.paymentIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(49, 53);
            this.paymentIcon.TabIndex = 0;
            this.paymentIcon.Text = "$";
            this.paymentIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTitle
            // 
            this.paymentTitle.AutoSize = true;
            this.paymentTitle.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.paymentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.paymentTitle.Location = new System.Drawing.Point(79, 32);
            this.paymentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentTitle.Name = "paymentTitle";
            this.paymentTitle.Size = new System.Drawing.Size(163, 27);
            this.paymentTitle.TabIndex = 1;
            this.paymentTitle.Text = "Payment Due";
            // 
            // paymentValue
            // 
            this.paymentValue.AutoSize = true;
            this.paymentValue.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.paymentValue.Location = new System.Drawing.Point(256, 32);
            this.paymentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentValue.Name = "paymentValue";
            this.paymentValue.Size = new System.Drawing.Size(88, 25);
            this.paymentValue.TabIndex = 2;
            this.paymentValue.Text = "$35.00";
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.booksPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.booksPanel.Controls.Add(this.booksTitle);
            this.booksPanel.Controls.Add(this.booksGrid);
            this.booksPanel.Location = new System.Drawing.Point(19, 321);
            this.booksPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(358, 279);
            this.booksPanel.TabIndex = 3;
            // 
            // booksTitle
            // 
            this.booksTitle.AutoSize = true;
            this.booksTitle.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold);
            this.booksTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.booksTitle.Location = new System.Drawing.Point(14, 12);
            this.booksTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.booksTitle.Name = "booksTitle";
            this.booksTitle.Size = new System.Drawing.Size(285, 24);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.booksGrid.ColumnHeadersHeight = 38;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.ReturnDue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.booksGrid.EnableHeadersVisualStyles = false;
            this.booksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.booksGrid.Location = new System.Drawing.Point(24, 38);
            this.booksGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(310, 220);
            this.booksGrid.TabIndex = 1;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 205;
            // 
            // ReturnDue
            // 
            this.ReturnDue.HeaderText = "Return Due";
            this.ReturnDue.Name = "ReturnDue";
            this.ReturnDue.ReadOnly = true;
            this.ReturnDue.Width = 155;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.rightPanel.Controls.Add(this.userNameLabel);
            this.rightPanel.Controls.Add(this.welcomeLabel);
            this.rightPanel.Controls.Add(this.logoutButton);
            this.rightPanel.Controls.Add(this.emailLabel);
            this.rightPanel.Controls.Add(this.emailIconPanel);
            this.rightPanel.Controls.Add(this.emailTextBox);
            this.rightPanel.Controls.Add(this.phoneLabel);
            this.rightPanel.Controls.Add(this.phoneIconPanel);
            this.rightPanel.Controls.Add(this.phoneTextBox);
            this.rightPanel.Controls.Add(this.historyButton);
            this.rightPanel.Controls.Add(this.editButton);
            this.rightPanel.Location = new System.Drawing.Point(391, -2);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(482, 604);
            this.rightPanel.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 29F, System.Drawing.FontStyle.Bold);
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(32, 23);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(281, 45);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "@User Name";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Georgia", 13F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(238)))));
            this.welcomeLabel.Location = new System.Drawing.Point(33, 72);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(360, 21);
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
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(353, 7);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(118, 47);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "↪ Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(32, 134);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 27);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-Mail";
            // 
            // emailIconPanel
            // 
            this.emailIconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.emailIconPanel.Controls.Add(this.emailIcon);
            this.emailIconPanel.Location = new System.Drawing.Point(32, 167);
            this.emailIconPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailIconPanel.Name = "emailIconPanel";
            this.emailIconPanel.Size = new System.Drawing.Size(49, 53);
            this.emailIconPanel.TabIndex = 4;
            // 
            // emailIcon
            // 
            this.emailIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.emailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.emailIcon.Location = new System.Drawing.Point(0, 0);
            this.emailIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(49, 53);
            this.emailIcon.TabIndex = 0;
            this.emailIcon.Text = "✉";
            this.emailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailIcon.Click += new System.EventHandler(this.emailIcon_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.emailTextBox.Location = new System.Drawing.Point(92, 177);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(376, 27);
            this.emailTextBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(32, 248);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(84, 27);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneIconPanel
            // 
            this.phoneIconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.phoneIconPanel.Controls.Add(this.phoneIcon);
            this.phoneIconPanel.Location = new System.Drawing.Point(32, 280);
            this.phoneIconPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneIconPanel.Name = "phoneIconPanel";
            this.phoneIconPanel.Size = new System.Drawing.Size(49, 53);
            this.phoneIconPanel.TabIndex = 7;
            // 
            // phoneIcon
            // 
            this.phoneIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.phoneIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.phoneIcon.Location = new System.Drawing.Point(0, 0);
            this.phoneIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneIcon.Name = "phoneIcon";
            this.phoneIcon.Size = new System.Drawing.Size(49, 53);
            this.phoneIcon.TabIndex = 0;
            this.phoneIcon.Text = "☎";
            this.phoneIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.phoneTextBox.Location = new System.Drawing.Point(92, 291);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(376, 27);
            this.phoneTextBox.TabIndex = 8;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.historyButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.historyButton.Location = new System.Drawing.Point(32, 459);
            this.historyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(262, 53);
            this.historyButton.TabIndex = 9;
            this.historyButton.Text = "◷   Borrowing / History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(238)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.editButton.Location = new System.Drawing.Point(326, 459);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 53);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "✎   Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(873, 602);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(889, 641);
            this.MinimumSize = new System.Drawing.Size(889, 641);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DustyCover - User Account";
            this.leftPanel.ResumeLayout(false);
            this.borrowingCard.ResumeLayout(false);
            this.borrowingCard.PerformLayout();
            this.readsCard.ResumeLayout(false);
            this.readsCard.PerformLayout();
            this.paymentCard.ResumeLayout(false);
            this.paymentCard.PerformLayout();
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.emailIconPanel.ResumeLayout(false);
            this.phoneIconPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}