namespace Encrypt___Decrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTNo3 = new System.Windows.Forms.Button();
            this.btnTYas2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBNO4 = new System.Windows.Forms.Button();
            this.btnBYas5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(639, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decrypt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(453, 261);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 34);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Start";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do You Want To\r\nEncrypt Text To Text ?";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTNo3
            // 
            this.btnTNo3.BackColor = System.Drawing.Color.White;
            this.btnTNo3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTNo3.ForeColor = System.Drawing.Color.Black;
            this.btnTNo3.Location = new System.Drawing.Point(487, 578);
            this.btnTNo3.Name = "btnTNo3";
            this.btnTNo3.Size = new System.Drawing.Size(83, 34);
            this.btnTNo3.TabIndex = 5;
            this.btnTNo3.Text = "No";
            this.btnTNo3.UseVisualStyleBackColor = false;
            this.btnTNo3.Visible = false;
            this.btnTNo3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnTYas2
            // 
            this.btnTYas2.BackColor = System.Drawing.Color.Snow;
            this.btnTYas2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTYas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTYas2.ForeColor = System.Drawing.Color.Black;
            this.btnTYas2.Location = new System.Drawing.Point(398, 578);
            this.btnTYas2.Name = "btnTYas2";
            this.btnTYas2.Size = new System.Drawing.Size(83, 34);
            this.btnTYas2.TabIndex = 6;
            this.btnTYas2.Text = "Yas";
            this.btnTYas2.UseVisualStyleBackColor = false;
            this.btnTYas2.Visible = false;
            this.btnTYas2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(609, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do You Want To\r\nEncrypt Text To Binary ?";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBNO4
            // 
            this.btnBNO4.BackColor = System.Drawing.Color.White;
            this.btnBNO4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBNO4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBNO4.ForeColor = System.Drawing.Color.Black;
            this.btnBNO4.Location = new System.Drawing.Point(789, 569);
            this.btnBNO4.Name = "btnBNO4";
            this.btnBNO4.Size = new System.Drawing.Size(83, 34);
            this.btnBNO4.TabIndex = 8;
            this.btnBNO4.Text = "No";
            this.btnBNO4.UseVisualStyleBackColor = false;
            this.btnBNO4.Visible = false;
            this.btnBNO4.Click += new System.EventHandler(this.btnNO4_Click);
            // 
            // btnBYas5
            // 
            this.btnBYas5.BackColor = System.Drawing.Color.Snow;
            this.btnBYas5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBYas5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBYas5.ForeColor = System.Drawing.Color.Black;
            this.btnBYas5.Location = new System.Drawing.Point(700, 569);
            this.btnBYas5.Name = "btnBYas5";
            this.btnBYas5.Size = new System.Drawing.Size(83, 34);
            this.btnBYas5.TabIndex = 9;
            this.btnBYas5.Text = "Yas";
            this.btnBYas5.UseVisualStyleBackColor = false;
            this.btnBYas5.Visible = false;
            this.btnBYas5.Click += new System.EventHandler(this.btnBYas5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Encrypt___Decrypt.Properties.Resources.first_image_encryption_decryption_high_res;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1207, 761);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 761);
            this.Controls.Add(this.btnBYas5);
            this.Controls.Add(this.btnBNO4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTYas2);
            this.Controls.Add(this.btnTNo3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encrypt & Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTNo3;
        private System.Windows.Forms.Button btnTYas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBNO4;
        private System.Windows.Forms.Button btnBYas5;
    }
}

