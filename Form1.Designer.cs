namespace DustyCover
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Allbtn = new System.Windows.Forms.Button();
            this.Activebtn = new System.Windows.Forms.Button();
            this.Duebtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Borrowing";
            // 
            // Allbtn
            // 
            this.Allbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allbtn.Location = new System.Drawing.Point(37, 101);
            this.Allbtn.Name = "Allbtn";
            this.Allbtn.Size = new System.Drawing.Size(131, 37);
            this.Allbtn.TabIndex = 1;
            this.Allbtn.Text = "All";
            this.Allbtn.UseVisualStyleBackColor = true;
            // 
            // Activebtn
            // 
            this.Activebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activebtn.Location = new System.Drawing.Point(219, 101);
            this.Activebtn.Name = "Activebtn";
            this.Activebtn.Size = new System.Drawing.Size(130, 37);
            this.Activebtn.TabIndex = 2;
            this.Activebtn.Text = "Active";
            this.Activebtn.UseVisualStyleBackColor = true;
            // 
            // Duebtn
            // 
            this.Duebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duebtn.Location = new System.Drawing.Point(407, 101);
            this.Duebtn.Name = "Duebtn";
            this.Duebtn.Size = new System.Drawing.Size(127, 37);
            this.Duebtn.TabIndex = 3;
            this.Duebtn.Text = "Due";
            this.Duebtn.UseVisualStyleBackColor = true;
            // 
            // Returnbtn
            // 
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(607, 101);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(129, 37);
            this.Returnbtn.TabIndex = 4;
            this.Returnbtn.Text = "Returned";
            this.Returnbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(37, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 476);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(36, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(36, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.Duebtn);
            this.Controls.Add(this.Activebtn);
            this.Controls.Add(this.Allbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Borrowing/History";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Allbtn;
        private System.Windows.Forms.Button Activebtn;
        private System.Windows.Forms.Button Duebtn;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

