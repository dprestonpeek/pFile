using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pFile
{
    public class Prefs
    {
        public List<string> favorites;
        public List<string> preferences;

        public string prefsFile = "./pFilePrefs.pfp";

        public static Prefs Instance { get { return instance; } set { Instance = instance; } }
        private static Prefs instance;

        public Prefs()
        {
            instance = this;
            favorites = new List<string>();
            preferences = new List<string>();
        }

        public void WritePrefsFile()
        {
            List<string> entireFile = new List<string>();
            string favString = "";
            string prefsString = "";

            foreach (string fav in favorites)
            {
                if (fav.Length > 0)
                {
                    favString += fav + ",";
                }
            }
            if (favString.Length > 0)
            {
                favString = favString.Substring(0, favString.Length - 1);
            }
            entireFile.Add(favString);
            foreach (string pref in preferences)
            {
                if (pref.Length > 0)
                {
                    prefsString += pref + "?";
                }
            }
            if (prefsString.Length > 0)
            {
                prefsString = prefsString.Substring(0, prefsString.Length - 1);
            }
            entireFile.Add(prefsString);

            File.WriteAllLines(Instance.prefsFile, entireFile.ToArray());
        }

        public void ImportPrefsFile(string filename)
        {
            string[] pfs = File.ReadAllLines(filename);
            favorites = pfs[0].Split(',').ToList();
            preferences = pfs[1].Split('?').ToList();
            WritePrefsFile();
        }

        public bool InitializePrefsFile(string panel1Url, string panel2Url, bool forceDefault)
        {
            if (!File.Exists(Prefs.Instance.prefsFile) || forceDefault)
            {
                Instance.favorites.Add(panel2Url);
                Instance.preferences.Add(panel1Url);
                Instance.preferences.Add(panel2Url);
                WritePrefsFile();
                return false;
            }
            else
            {
                ImportPrefsFile(prefsFile);
                return true;
            }
        }
    }
}
