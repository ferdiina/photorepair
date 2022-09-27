using System.Net.Security;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.Diagnostics;

namespace photorepair
{
    public partial class Form1 : Form
    {
        
        
        public static string ImagePathToBase64(string path)
        {
            using System.Drawing.Image image = System.Drawing.Image.FromFile(path);
            using MemoryStream m = new MemoryStream();
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }


        public Form1()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "图片文件|*.jpg";
            openFileDialog1.Title = "打开";
            openFileDialog1.ShowDialog();
            string[] picturePath = openFileDialog1.FileNames;
            Bitmap picture = new Bitmap(picturePath[0]);  //第一张图片
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = picture;
            picturePath1.Text = picturePath[0];
            base64box1.Text = ImagePathToBase64(picturePath1.Text);

        }





        private void picturePath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void keytext1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }   
}