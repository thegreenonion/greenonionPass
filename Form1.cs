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
        public int localrand;
        public int[] encrypted;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text != "")
            {
                passwd = txtLogin.Text;
                lblA.Text = ConvertToASCIIaddition(passwd) + "";
                txtPass.Visible = true;
                cmbEncrypt.Visible = true;
            }



            //lblRandom.Text = System.Convert.ToString(GetRandomNumber(SetRandomObject(ConvertToASCIIint(passwd))));
            //GetRandomNumber(SetRandomObject(ConvertToASCIIstring(passwd)));
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

        public int ConvertToASCIIaddition(string s)
        {
            pass = "";
            passint = 0;

            foreach (char c in s)
            {
                passint += System.Convert.ToInt32(c);
            }

            return passint;
        }

        public Random SetRandomObject(int seed)
        {
            Random randomobject = new Random(seed);

            return randomobject;
        }

        public int GetRandomNumber(Random randobj, int number)
        {
            lblRandom.Text = "";
            for(int j = 1; j < number; j++)
            {
                //lblRandom.Text += randobj.Next() + "\n";
                localrand = randobj.Next();
            }
            lblRandom.Text = localrand.ToString();
            return localrand;

        }

        public int[] encrypt(string plain)     //noch nicht fertig
        {
            int x = 0;
            
            foreach (char c in plain)
            {
                x++;
            }
            int i = 0;

            encrypted = new int[x];
            /*for (i = 0; i < 2; i++)
            {*/
            foreach (char c in plain)
            {
                //int k = 0;
                localcrypt = Convert.ToInt32(c);
                encrypted[i] = localcrypt + GetRandomNumber(SetRandomObject(passint), localcrypt);
                //localcrypt += GetRandomNumber(SetRandomObject(passint), i);
                //lblCrypt.Text += localcrypt + "\n";
                //encrypted[i] = localcrypt;
                //localcrypt = localcrypt
                i++;
            }

                /*if (i == 0)
                {
                    for (int j = 0; j < encrypted.Length; j++)
                    {
                        encrypted[j] = 0;
                    }
                }*/
            //}

            return encrypted;
        }

        private void cmbEncrypt_Click(object sender, EventArgs e)
        {
            lblCrypt.Text = "";
            int[] showcrypto;
            showcrypto = encrypt(txtPass.Text);
            foreach(int i in showcrypto)
            {
                lblCrypt.Text += /*Convert.ToString(i)*/i + "\n";
            }
        }

        private void cmbClear_Click(object sender, EventArgs e)
        {
            lblCrypt.Text = "";
        }

        private void cmbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
