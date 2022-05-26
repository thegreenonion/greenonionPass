using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public int localcrypt;
        public string ASCIIcrypt;
        public int random;
        public int[] secret = { 1, 2, 3, 4, 5, 6 };
        public int passint;
        public string pass;
        public string passwd;
        public string passwdASCII;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbLogin_Click(object sender, EventArgs e)
        {
            passwd = txtLogin.Text;
            lblA.Text = ConvertToASCIIstring(passwd) + "";


            //lblRandom.Text = System.Convert.ToString(GetRandomNumber(SetRandomObject(ConvertToASCIIint(passwd))));
            GetRandomNumber(SetRandomObject(ConvertToASCIIstring(passwd)));
            encrypt("MyPassword");
        }

        public int ConvertToASCIIint(string s)
        {
            passint = 0;
            pass = "";

            foreach(char c in s)
            {
                pass += System.Convert.ToInt32(c);
            }
            passint = System.Convert.ToInt32(pass);

            return passint;
        }

        public int ConvertToASCIIstring(string s)
        {
            pass = "";
            passint = 0;

            foreach (char c in s)
            {
                //pass += System.Convert.ToInt32(c);
                passint += System.Convert.ToInt32(c);
            }

            return passint;
        }

        public Random SetRandomObject(int seed)
        {
            Random randomobject = new Random(seed);

            return randomobject;
        }

        public void GetRandomNumber(Random randobj)
        {
            lblRandom.Text = "";
            for(int j = 0; j < secret.Length; j++)
            {
                lblRandom.Text += randobj.Next() + "\n";
            }

        }

        public string encrypt(string plain)     //noch nicht fertig
        {
            foreach(char c in plain)
            {
                //int k = 0;
                localcrypt = Convert.ToInt32(c);

                //localcrypt = localcrypt + 
            }

            return ASCIIcrypt;
        }
    }
}
