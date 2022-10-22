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
using System.Collections;

public partial class dataManager
{

    public static Dictionary<string, object> dict = new Dictionary<string, object>();
    // Start is called before the first frame update

    public static int[] LoadEncryptedPasswordArray(string passwordName)
    {
        StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/ASCII_Shuffler/" + passwordName);

        var jsonString = sr.ReadLine();
        sr.Close();

        dict.Clear();
        dict = Json.Deserialize(jsonString) as Dictionary<string, object>;

        //int x = 0;

        //foreach(KeyValuePair<string, object> kvp in dict)
        //{
        //    x++;
        //}

        int[] loadedcrypto = new int[dict.Count];

        for (int i = 0; i < dict.Count; i++)
        {
            loadedcrypto[i] = unchecked((int)((long)dict[i + ""]));
        }

        return loadedcrypto;
    }

    public static string LoadEncryptedPasswordString(string passwordName)
    {
        StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/AES/" + passwordName);

        var jsonString = sr.ReadLine();
        sr.Close();

        dict.Clear();
        dict = Json.Deserialize(jsonString) as Dictionary<string, object>;

        string[] parts = passwordName.Split(new char[] { '.' });

        //int x = 0;

        //foreach(KeyValuePair<string, object> kvp in dict)
        //{
        //    x++;
        //}

        string loadedcrypto = unchecked((string)((string)dict[parts[0]]));

        /*for (int i = 0; i < dict.Count; i++)
        {
            loadedcrypto[i] = unchecked((int)((long)dict[i + ""]));
        }*/

        return loadedcrypto;
    }

    public static void SavePasswordString(string passwordName, string cipherPassword)
    {
        dict.Clear();

        dict.Add(passwordName, cipherPassword);

        var str = Json.Serialize(dict);
        //Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
        //DirectoryInfo dirInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        //dirInfo.Attributes &= ~FileAttributes.ReadOnly;
        StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/AES/" + passwordName + ".gppass");
        sw.WriteLine(str);
        sw.Flush();
        sw.Close();
    }

    public static void SavePasswordArray(string passwordName, int[] savecrypto)
    {
        dict.Clear();

        int x = 0;
        foreach (int i in savecrypto)
        {
            dict.Add(x + "", i);
            x++;
        }
        var str = Json.Serialize(dict);
        //Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
        //DirectoryInfo dirInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        //dirInfo.Attributes &= ~FileAttributes.ReadOnly;
        StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/ASCII_Shuffler/" + passwordName + ".gppass");
        sw.WriteLine(str);
        sw.Flush();
        sw.Close();
    }
}