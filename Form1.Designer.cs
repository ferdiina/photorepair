namespace photorepair
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
            this.uploadbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressbutton1 = new System.Windows.Forms.Button();
            this.downloadbutton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturePath1 = new System.Windows.Forms.TextBox();
            this.base64box1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.keytext1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadbutton1
            // 
            this.uploadbutton1.Location = new System.Drawing.Point(49, 51);
            this.uploadbutton1.Name = "uploadbutton1";
            this.uploadbutton1.Size = new System.Drawing.Size(76, 25);
            this.uploadbutton1.TabIndex = 0;
            this.uploadbutton1.Text = "选择图片";
            this.uploadbutton1.UseVisualStyleBackColor = true;
            this.uploadbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(271, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 568);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // progressbutton1
            // 
            this.progressbutton1.Location = new System.Drawing.Point(10, 458);
            this.progressbutton1.Name = "progressbutton1";
            this.progressbutton1.Size = new System.Drawing.Size(75, 23);
            this.progressbutton1.TabIndex = 2;
            this.progressbutton1.Text = "AI处理";
            this.progressbutton1.UseVisualStyleBackColor = true;
            this.progressbutton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // downloadbutton1
            // 
            this.downloadbutton1.Location = new System.Drawing.Point(185, 458);
            this.downloadbutton1.Name = "downloadbutton1";
            this.downloadbutton1.Size = new System.Drawing.Size(75, 23);
            this.downloadbutton1.TabIndex = 3;
            this.downloadbutton1.Text = "下载结果";
            this.downloadbutton1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturePath1
            // 
            this.picturePath1.Location = new System.Drawing.Point(10, 82);
            this.picturePath1.Name = "picturePath1";
            this.picturePath1.Size = new System.Drawing.Size(252, 23);
            this.picturePath1.TabIndex = 4;
            this.picturePath1.TextChanged += new System.EventHandler(this.picturePath1_TextChanged);
            // 
            // base64box1
            // 
            this.base64box1.Location = new System.Drawing.Point(10, 153);
            this.base64box1.Multiline = true;
            this.base64box1.Name = "base64box1";
            this.base64box1.Size = new System.Drawing.Size(250, 272);
            this.base64box1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(10, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "路径";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(10, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Base64";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(10, 487);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Appcode";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // keytext1
            // 
            this.keytext1.Location = new System.Drawing.Point(10, 516);
            this.keytext1.Name = "keytext1";
            this.keytext1.Size = new System.Drawing.Size(250, 23);
            this.keytext1.TabIndex = 9;
            this.keytext1.TextChanged += new System.EventHandler(this.keytext1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 615);
            this.Controls.Add(this.keytext1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.base64box1);
            this.Controls.Add(this.picturePath1);
            this.Controls.Add(this.downloadbutton1);
            this.Controls.Add(this.progressbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uploadbutton1);
            this.Name = "Form1";
            this.Text = "AIPhotorepair";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uploadbutton1;
        private PictureBox pictureBox1;
        private Button progressbutton1;
        private Button downloadbutton1;
        private OpenFileDialog openFileDialog1;
        private TextBox picturePath1;
        private TextBox base64box1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox keytext1;
    }
}