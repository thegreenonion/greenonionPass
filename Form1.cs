﻿using System;
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
using static dataManager;
using System.Diagnostics;

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
            SaveLogfile("Attempting Login");
            if(txtLogin.Text != "")
            {
                cobEncryption.Visible = true;
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
                SaveLogfile("Login Succesful");
            }
            else
            {
                SaveLogfile("Login failed");
            }



            //lblRandom.Text = System.Convert.ToString(GetRandomNumber(SetRandomObject(ConvertToASCIIint(passwd))));
            //GetRandomNumber(SetRandomObject(ConvertToASCIIstring(passwd)));
        }

        public int ConvertToASCIIint(string s)
        {
            SaveLogfile("Calling method 'ConvertToASCIIint'");
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
            SaveLogfile("Calling method 'ConvertToASCIIaddition'");
            //pass = "";
            int localpassint = 0;

            foreach (char c in s)
            {
                localpassint += Convert.ToInt32(c);
            }

            return localpassint;
        }

        public Random SetRandomObject(int seed) // Initialisiert eine Zufallszahl mit dem Seed
        {
            //SaveLogfile("Calling method 'SetRandomObject'");  //Das müllt das Logfile zu!
            Random randomobject = new Random(seed);

            return randomobject;
        }

        public int GetRandomNumber(Random randobj, int number) //Holt die number-nte Zufallszahl mit dem Seed des randobj. Sollte mit SetRandomObject benutzt werden
        {
            //SaveLogfile("Calling method 'GetRandomNumber'"); //Das müllt das Logfile zu!
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
            SaveLogfile("Try encrypting plaintext (ASCII-SHUFFLER)");
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

            SaveLogfile("Encryption succesfully (ASCII-SHUFFLER)");

            return encrypted;
        }

        private void cmbEncrypt_Click(object sender, EventArgs e)
        {
            SaveLogfile("Starting encryption");
            lblCrypt.Text = "";
            if(cobEncryption.Text == "Use ASCII-Shuffler encryption")
            {
                SaveLogfile("Using ASCII-SHUFLLER");
                int[] showcrypto;
                showcrypto = encrypt(txtPass.Text);
                foreach (int i in showcrypto)
                {
                    lblCrypt.Text += /*Convert.ToString(i)*/i + "\n";
                }
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    "/ThePasswordManager/" + txtPasswordName.Text + ".gppass"))
                {
                    MessageBox.Show("Please enter the password you first encrypted this file to overwrite it " +
                        "in the text box named ", "Overwrite password",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                dataManager.SavePasswordArray(txtPasswordName.Text, encrypt(txtPass.Text));
                SaveLogfile("Saved encrypted password (" + txtPasswordName.Text + ")");
            }
            else if(cobEncryption.Text == "Use AES encryption")
            {
                SaveLogfile("Using AES");
                string aescrypt = AES_Manager.Encrypt(txtPass.Text, GetStringSha256Hash(txtLogin.Text + nudPIN.Value));
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    "/ThePasswordManager/" + txtPasswordName.Text + ".gppass"))
                {
                    MessageBox.Show("Please enter the password you first encrypted this file to overwrite it " +
                        "in the text box named ", "Overwrite password",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                dataManager.SavePasswordString(txtPasswordName.Text, aescrypt, GetStringSha256Hash(txtLogin.Text + nudPIN.Value));
                SaveLogfile("Saved encrypted password (" + txtPasswordName.Text + ")");
            }
        }

        private void cmbClose_Click(object sender, EventArgs e)
        {
            SaveLogfile("Closing greenonionPass");
            Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SaveLogfile("Starting greenonionPass");
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\AES\\")) //Nötige Ordner erstellen, falls nicht vorhanden
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\AES\\");
            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\ASCII_Shuffler\\"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\ASCII_Shuffler\\");
            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\Log\\"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\Log\\");
            }
            
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\Log\\greenonionPass.log")) //Logfile erstellen, falls nicht vorhanden
            {
                
                var logfile = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\Log\\greenonionPass.log");
                logfile.Close();
            }

            label6.Text = "View log at " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ThePasswordManager\\Logs\\greenonionPass.log";
            passwordchar = txtPass.PasswordChar;
            cobEncryption.Text = "Use ASCII-Shuffler encryption";
        }

        private void cmbPassVisibility_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                SaveLogfile("Enabled password visibility");
                txtPass.Font = new Font("Microsoft Sans Serif", 10f);
                txtPass.PasswordChar = (char)0;
                isPasswordVisible = true;
                cmbPassVisibility.Text = "Make password invisible";

            }
            else
            {
                SaveLogfile("Disabled password visibility");
                txtPass.Font = new Font("Microsoft Sans Serif", 4f);
                txtPass.PasswordChar = passwordchar;
                isPasswordVisible = false;
                cmbPassVisibility.Text = "Make password visible";
            }
        }

        public void loadAllPasswords()
        {
            SaveLogfile("Attempting load all passwords");
            //Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/ASCII_Shuffler/";
            DirectoryInfo d = new DirectoryInfo(filepath);
            
            int l = 0;
            foreach(var file in d.GetFiles("*.gppass"))
            {
                l++;
            }
            if(l != 0)
            {
                lstPassword.Items.Add("ASCII-SHUFFLER ENCRYPTED PASSWORDS:");
                lstPassword.Items.Add("");
            }

            foreach (var file in d.GetFiles("*.gppass")) // ASCII-Shuffler Passwörter entschlüsseln
            {
                string[] parts = file.Name.Split(new char[] { '.' });
                lblA.Text = file.Name;
                //File.SetAttributes(file.Name.ToString(), FileAttributes.Normal);
                string decryptedPassword = "";
                lstPassword.Items.Add("\nPassword name: " + parts[0]);
                char[] decryptedPasswordChar = new char[DecryptEncryptedPasswordArray(dataManager.LoadEncryptedPasswordArray(file.Name)).Length];
                decryptedPasswordChar = DecryptEncryptedPasswordArray(dataManager.LoadEncryptedPasswordArray(file.Name));
                foreach (char c in decryptedPasswordChar)
                {
                    decryptedPassword += c;
                    //lstPassword.Items.Add(c);
                }
                lstPassword.Items.Add(decryptedPassword);
                lstPassword.Items.Add("");

                /*lstPassword.Items.Add(DecryptAesCipherPassword(dataManager.LoadEncryptedPasswordString(file.Name), GetStringSha256Hash(txtLogin.Text)));
                lstPassword.Items.Add("");*/
            }

            filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/AES/";
            d = new DirectoryInfo(filepath);
            int abc = 0;

            foreach (var file in d.GetFiles("*.gppass")) //Dateien die das Passwort matchen zählen
            {
                if (dataManager.LoadEncryptedPasswordString(file.Name)[1] == GetStringSha256Hash(txtLogin.Text + nudPIN.Value))
                {
                    abc++;
                }
            }
            if(abc != 0)
            {
                lstPassword.Items.Add("AES ENCRPYPTED PASSWORDS:");
                lstPassword.Items.Add("");
            }

            int x = 0;

            foreach (var file in d.GetFiles("*.gppass")) //AES Passwörter entschlüsseln
            {
                string[] parts = file.Name.Split(new char[] { '.' });
                if (dataManager.LoadEncryptedPasswordString(file.Name)[1] == GetStringSha256Hash(txtLogin.Text + nudPIN.Value))
                {
                    lstPassword.Items.Add("Password name: " + parts[0]);
                    lstPassword.Items.Add(DecryptAesCipherPassword(dataManager.LoadEncryptedPasswordString(file.Name)[0], GetStringSha256Hash(txtLogin.Text)));
                    lstPassword.Items.Add("");
                }
                else
                {
                    x++;
                }
            }
            if (x != 0)
            {
                lstPassword.Items.Add("NOT DECRYPTED:");
                lstPassword.Items.Add("");
                foreach (var file in d.GetFiles("*.gppass"))
                {
                    if (dataManager.LoadEncryptedPasswordString(file.Name)[1] != GetStringSha256Hash(txtLogin.Text + nudPIN.Value))
                    {
                        lstPassword.Items.Add(file.Name);

                    }
                }
            }

            SaveLogfile("Successfully loaded all passwords");
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

        public string DecryptAesCipherPassword(string cipherPassword, string password)
        {
            string dec = AES_Manager.Decrypt(cipherPassword, password);

            return dec;
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
            cobEncryption.Visible = false;
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
        public byte[] ComputeIV(string password)
        {
            using (SymmetricAlgorithm crypt = Aes.Create())
            using (HashAlgorithm hash = MD5.Create())
            {
                crypt.Key = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                crypt.GenerateIV();

                return crypt.IV;
            }
        }
    }
}
