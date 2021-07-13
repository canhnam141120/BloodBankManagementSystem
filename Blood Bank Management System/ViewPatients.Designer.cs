
namespace Blood_Bank_Management_System
{
    partial class ViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatients));
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PGen = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PBGroup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PAddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PNum = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(371, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 50;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(620, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 48;
            this.label16.Text = "Adress";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(29, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 29);
            this.label15.TabIndex = 47;
            this.label15.Text = "Gender";
            // 
            // PGen
            // 
            this.PGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGen.ForeColor = System.Drawing.Color.DarkRed;
            this.PGen.FormattingEnabled = true;
            this.PGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGen.Location = new System.Drawing.Point(25, 166);
            this.PGen.Name = "PGen";
            this.PGen.Size = new System.Drawing.Size(233, 39);
            this.PGen.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(318, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 29);
            this.label14.TabIndex = 45;
            this.label14.Text = "Blood Group";
            // 
            // PBGroup
            // 
            this.PBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.PBGroup.FormattingEnabled = true;
            this.PBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.PBGroup.Location = new System.Drawing.Point(323, 167);
            this.PBGroup.Name = "PBGroup";
            this.PBGroup.Size = new System.Drawing.Size(233, 39);
            this.PBGroup.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(620, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 29);
            this.label13.TabIndex = 43;
            this.label13.Text = "Phone";
            // 
            // PPhone
            // 
            this.PPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.PPhone.Location = new System.Drawing.Point(625, 85);
            this.PPhone.Name = "PPhone";
            this.PPhone.Size = new System.Drawing.Size(233, 38);
            this.PPhone.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(318, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 29);
            this.label12.TabIndex = 41;
            this.label12.Text = "Age";
            // 
            // PAge
            // 
            this.PAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAge.ForeColor = System.Drawing.Color.DarkRed;
            this.PAge.Location = new System.Drawing.Point(323, 85);
            this.PAge.Name = "PAge";
            this.PAge.Size = new System.Drawing.Size(233, 38);
            this.PAge.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(29, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Name";
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.ForeColor = System.Drawing.Color.DarkRed;
            this.PName.Location = new System.Drawing.Point(25, 85);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(233, 38);
            this.PName.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(330, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "View Patients";
            // 
            // PAddress
            // 
            this.PAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAddress.ForeColor = System.Drawing.Color.DarkRed;
            this.PAddress.Location = new System.Drawing.Point(625, 167);
            this.PAddress.Name = "PAddress";
            this.PAddress.Size = new System.Drawing.Size(233, 38);
            this.PAddress.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(567, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 52;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 318);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PNum
            // 
            this.PNum.Location = new System.Drawing.Point(39, 224);
            this.PNum.Multiline = true;
            this.PNum.Name = "PNum";
            this.PNum.Size = new System.Drawing.Size(51, 41);
            this.PNum.TabIndex = 54;
            this.PNum.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(177, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 55;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PAddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PGen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PBGroup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PPhone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PAge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patients";
            this.Load += new System.EventHandler(this.ViewPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox PGen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox PBGroup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PAddress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PNum;
        private System.Windows.Forms.Button button3;
    }
}