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

public partial class dataManager
{

    public static Dictionary<string, int> dict = new Dictionary<string, int>();
    // Start is called before the first frame update

    public static int[] LoadEncryptedPasswordArray(string passwordName)
    {
        StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/" + passwordName);
        var jsonString = sr.ReadLine();
        sr.Close();

        dict.Clear();
        dict = Json.Deserialize(jsonString) as Dictionary<string, int>;
        int[] loadedcrypto = new int[dict.Count];

        for (int i = 0; i < dict.Count; i++)
        {
            loadedcrypto[i] = dict[i + ""];
        }

        return loadedcrypto;
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
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/");
        StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ThePasswordManager/" + passwordName + ".txt");
        sw.WriteLine(str);
        sw.Flush();
        sw.Close();
    }
}