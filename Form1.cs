using System.Net.Security;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.Diagnostics;
using System.Reflection.Emit;

namespace photorepair
{


    public partial class Form1 : Form
    {
        public const String host = "https://photo.market.alicloudapi.com";
        public const String path = "/photo/repairPost";
        public const String method = "POST";
        public const String appcode = "";



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

        public void button1_Click(object sender, EventArgs e)
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
            String ImageBase64 = base64box1.Text;


    }




    static void Main(string[] args)
        {
            String querys = "";
            String bodys = "{\"image\":\"ImageBase64;}";
            String url = host + path;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (host.Contains("https://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
            httpRequest.ContentType = "application/json; charset=UTF-8";
            if (0 < bodys.Length)
            {
                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }

            Console.WriteLine(httpResponse.StatusCode);
            Console.WriteLine(httpResponse.Method);
            Console.WriteLine(httpResponse.Headers);
            Stream st = httpResponse.GetResponseStream();
            StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("\n");

        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
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

        public void keytext1_TextChanged(object sender, EventArgs e)
        {
            String appcode = keytext1.Text;
          //  base64box1.Text = appcode;


}
    }
       
}