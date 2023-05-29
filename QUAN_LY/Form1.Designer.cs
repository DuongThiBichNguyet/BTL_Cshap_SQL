namespace QUAN_LY
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ShowData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Show3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowData.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_ShowData.Location = new System.Drawing.Point(620, 272);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(115, 45);
            this.btn_ShowData.TabIndex = 1;
            this.btn_ShowData.Text = "Hóa đơn";
            this.btn_ShowData.UseVisualStyleBackColor = false;
            this.btn_ShowData.Click += new System.EventHandler(this.btn_ShowData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(472, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Danh sách khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show3
            // 
            this.Show3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Show3.Location = new System.Drawing.Point(314, 272);
            this.Show3.Name = "Show3";
            this.Show3.Size = new System.Drawing.Size(115, 45);
            this.Show3.TabIndex = 3;
            this.Show3.Text = "Nhân Viên";
            this.Show3.UseVisualStyleBackColor = false;
            this.Show3.Click += new System.EventHandler(this.Show3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QUAN_LY.Properties.Resources.HastyResponsibleLeopard_max_1mb;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Menu.Location = new System.Drawing.Point(158, 272);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(115, 45);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Show3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ShowData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "-------------";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ShowData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Show3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Menu;
    }
}

