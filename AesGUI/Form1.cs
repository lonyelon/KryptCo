using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace AesGUI
{
    public partial class Form1 : Form
    {
        private Aes x = new Aes();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_pwd.Text = x.readKey();
            txt_IV.Text = x.readIV();
            lb_version.Text = "Loncrypt " + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String o = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(txt_txt.Text));
            txt_cry.Text = x.AesCipher(o ,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] Decrypt = Convert.FromBase64String(x.AesCipher(txt_cry.Text, 1));
            String result = UTF8Encoding.UTF8.GetString(Decrypt);
            txt_txt.Text = result;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            x.generate();
            txt_pwd.Text = x.readKey();
            txt_IV.Text = x.readIV();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            var message = Encoding.ASCII.GetBytes(txt_crypto_pwd.Text);
            SHA256Managed hashString = new SHA256Managed();
            MD5 md5 = MD5.Create();
            var pValue = hashString.ComputeHash(message);
            var vValue = md5.ComputeHash(message);

            x.set(Convert.ToBase64String(pValue), Convert.ToBase64String(vValue));
            txt_pwd.Text = Convert.ToBase64String(pValue);
            txt_IV.Text = Convert.ToBase64String(vValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x.set(txt_pwd.Text, txt_IV.Text);
            txt_pwd.Text = x.readKey();
            txt_IV.Text = x.readIV();
        }
    }

    class Aes
    {
        private Rijndael aes = Rijndael.Create();

        public Aes()
        {
            aes.KeySize = 256;
            aes.BlockSize = 128;
            generate();
        }

        public void generate()
        {
            aes.GenerateKey();
            aes.GenerateIV();
        }

        public void set(String Key, String IV)
        {
            try
            {
                aes.Key = Convert.FromBase64String(Key);
                aes.IV = Convert.FromBase64String(IV);
            }
            catch (Exception e)
            {
                MessageBox.Show("Please enter a 256 bit password and 128 bit IV");
            }
        }

        public String readKey()
        {
            return Convert.ToBase64String(aes.Key);
        }

        public String readIV()
        {
            return Convert.ToBase64String(aes.IV);
        }

        public String AesCipher(String text, int mode)
        {
            try
            {
                MemoryStream mems = new MemoryStream();
                CryptoStream cryptoStream = null;

                if (mode == 0)
                    cryptoStream = new CryptoStream(mems, aes.CreateEncryptor(), CryptoStreamMode.Write);
                else
                    cryptoStream = new CryptoStream(mems, aes.CreateDecryptor(), CryptoStreamMode.Write);

                byte[] txt = Convert.FromBase64String(text);

                cryptoStream.Write(txt, 0, txt.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(mems.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while decrypting, is yout password ok?");
                return Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes("Error"));
            }
        }

    }
}
