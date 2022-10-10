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
using MiniJSON;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Dictionary<int, object> dict = new Dictionary<int, object>();
        public bool isPasswordVisible = false;
        public char passwordchar;
        public int localcrypt = 0;
        public string ASCIIcrypt = "";
        public int random = 0;
        //public int[] secret = { 1, 2, 3, 4, 5, 6 };
        public Int32 passint = 0;
        public string pass = "";
        public string passwd = "";
        public string passwdASCII = "";
        public int localrand = 0;
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
                //passint = ConvertToASCIIaddition(passwd);
                passint = ConvertStringToInt(GetStringSha256Hash(passwd));
                if (chkPIN.Checked)
                {
                    pass = passint.ToString() + nudPIN.Value.ToString();
                    passint = Int32.Parse(pass);
                }
                lstPassword.Items.Clear();
                loadAllPasswords();
                lblA.Text = passint + "";
                txtPass.Visible = true;
                txtPasswordName.Visible = true;
                cmbEncrypt.Visible = true;
                cmbPassVisibility.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                
            }



            //lblRandom.Text = System.Convert.ToString(GetRandomNumber(SetRandomObject(ConvertToASCIIint(passwd))));
            //GetRandomNumber(SetRandomObject(ConvertToASCIIstring(passwd)));
        }

        public int ConvertToASCIIint(string s)
        {
            int localpassint = 0;
            pass = "";

            foreach(char c in s)
            {
                pass += Convert.ToInt32(c);
            }
            localpassint = Convert.ToInt32(pass);

            return localpassint;
        }

        public int ConvertToASCIIaddition(string s)
        {
            //pass = "";
            int localpassint = 0;

            foreach (char c in s)
            {
                localpassint += Convert.ToInt32(c);
            }

            return localpassint;
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

        public int[] encrypt(string plain)
        {
            int x = 0;
            
            foreach (char c in plain)
            {
                x++;
            }

            encrypted = new int[x];
            /*for (i = 0; i < 2; i++)
            {*/

            int i = 0;
            int j = 2;

            foreach (char c in plain)
            {
                //int k = 0;
                localcrypt = Convert.ToInt32(c);
                encrypted[i] = localcrypt + GetRandomNumber(SetRandomObject(passint), j);
                //localcrypt += GetRandomNumber(SetRandomObject(passint), i);
                //lblCrypt.Text += localcrypt + "\n";
                //encrypted[i] = localcrypt;
                //localcrypt = localcrypt
                i++;
                j++;
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
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                "/ThePasswordManager/" + txtPasswordName.Text + ".gppass"))
            {
                MessageBox.Show("Please enter the password you first encrypted this file to overwrite it " +
                    "in the text box named ", "Overwrite password",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            dataManager.SavePasswordArray(txtPasswordName.Text, encrypt(txtPass.Text));
        }

        private void cmbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //public void savePasswords()
        //{
        //    /*dict.Clear();
        //    StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/" + "passwords.txt");
        //    var jsonString = sr.ReadLine();
        //    sr.Close();*/

        //    //dict = Json.Deserialize(jsonString) as Dictionary<int, object>;

        //    int[] savecrypto = new int[encrypt(txtPass.Text).Length];
        //    savecrypto = encrypt(txtPass.Text);
        //    int x = 0;
        //    foreach(int i in savecrypto)
        //    {
        //        dict.Add(x, i);
        //        x++;
        //    }

        //    var str = Json.Serialize(dict);
        //    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
        //    StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/" + "passwords.txt");
        //    sw.WriteLine(str);
        //    sw.Flush();
        //    sw.Close();
        //}
        
        private void Form1_Load(object sender, EventArgs e)
        {
            passwordchar = txtPass.PasswordChar;
        }

        private void cmbPassVisibility_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                txtPass.Font = new Font("Microsoft Sans Serif", 10f);
                txtPass.PasswordChar = (char)0;
                isPasswordVisible = true;
                cmbPassVisibility.Text = "Make password invisible";

            }
            else
            {
                txtPass.Font = new Font("Microsoft Sans Serif", 4f);
                txtPass.PasswordChar = passwordchar;
                isPasswordVisible = false;
                cmbPassVisibility.Text = "Make password visible";
            }
        }

        public void loadAllPasswords()
        {
            //Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.gppass"))
            {
                lblA.Text = file.Name;
                //File.SetAttributes(file.Name.ToString(), FileAttributes.Normal);
                string decryptedPassword = "";
                lstPassword.Items.Add("\n" + file.Name);
                char[] decryptedPasswordChar = new char[DecryptEncryptedPasswordArray(dataManager.LoadEncryptedPasswordArray(file.Name)).Length];
                decryptedPasswordChar = DecryptEncryptedPasswordArray(dataManager.LoadEncryptedPasswordArray(file.Name));
                foreach (char c in decryptedPasswordChar)
                {
                    decryptedPassword += c;
                    //lstPassword.Items.Add(c);
                }
                lstPassword.Items.Add(decryptedPassword);
                lstPassword.Items.Add("");
            }
        }

        public char[] DecryptEncryptedPasswordArray(int[] passwordarray)
        {
            int decryptedPasswordCharASCII = 0;
            int x = 2;
            int j = 0;
            char[] decryptedPasswordArray = new char[passwordarray.Length];
            
            foreach(int i in passwordarray)
            {
                decryptedPasswordCharASCII = i - GetRandomNumber(SetRandomObject(passint), x);
                decryptedPasswordArray[j] = (char)decryptedPasswordCharASCII;
                x++;
                j++;
            }

            return decryptedPasswordArray;
        }

        private void chkPIN_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPIN.Checked)
            {
                nudPIN.Visible = false;
                label4.Visible = false;
            }
            else
            {
                nudPIN.Visible = true;
                label4.Visible = true;
            }
        }

        private void cmbLock_Click(object sender, EventArgs e)
        {
            lstPassword.Items.Clear();
            txtPass.Text = "";
            nudPIN.Value = 0;
            txtLogin.Text = "";
            txtPasswordName.Text = "";
            lblA.Text = "";
            lblCrypt.Text = "";
            lblRandom.Text = "";
            label1.Visible = false;
            label2.Visible = false;
            txtPasswordName.Visible = false;
            txtPass.Visible = false;
            cmbEncrypt.Visible = false;
            cmbPassVisibility.Visible = false;
        }

        //public static byte[] GetHash(string inputString)
        //{
        //    using (HashAlgorithm algorithm = SHA256.Create())
        //        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        //}

        //public static string GetHashString(string inputString)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (byte b in GetHash(inputString))
        //        sb.Append(b.ToString("X2"));

        //    return sb.ToString();
        //}

        public static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public static byte[] GetByteSha256Hash(string text)
        {
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return hash;
            }
        }

        public static int ConvertStringToInt(string inputstring)
        {
            int result = 0;
            foreach(char c in inputstring)
            {
                result += (int)c;
            }

            return result;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (lstPassword.SelectedItems.Count != 0)
            {
                //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\" + lstPassword.SelectedItem.ToString());
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\" + lstPassword.SelectedItem.ToString()))
                {
                    lstPassword.Items.RemoveAt(lstPassword.SelectedIndex + 1);
                    lstPassword.Items.RemoveAt(lstPassword.SelectedIndex);
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                        "/ThePasswordManager/" + lstPassword.SelectedItem.ToString());

                }
                else
                {
                    MessageBox.Show("File does not exist or no item selected" +
                        "or item selected is no file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            /*else
            {
                MessageBox.Show("File does not exist or no item selected" +
                        "or item selected is no file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }*/
        }

        private void cmbTest_Click(object sender, EventArgs e)
        {
            lblTestEnc.Text = AES_Manager.Encrypt("123456", "hallo");
        }

        public byte[] ComputeIVandKey(string password)
        {
            using (SymmetricAlgorithm crypt = Aes.Create())
            using (HashAlgorithm hash = MD5.Create())
            {
                crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                crypt.GenerateIV();

                return crypt.IV;
            }
        }

        private void cmbTestDec_Click(object sender, EventArgs e)
        {
            lblDec.Text = AES_Manager.Decrypt(lblTestEnc.Text, "hallo");
        }
    }
}
