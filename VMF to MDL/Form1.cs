using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMF_to_MDL
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<string> steamLibraries;
        Dictionary<string, string> games = new Dictionary<string, string>();
        Dictionary<string, string> mods = new Dictionary<string, string>();

        string[] SUPPORTED_GAMES = {
            "source sdk base 2013 singleplayer",
            "half-life 2",
            "left 4 dead 2",
            "counter-strike global offensive",
            "black mesa"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Valve Map Files (*.vmf)|*.vmf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in dialog.FileNames)
                {
                    vmfListBox.Items.Add(fileName);
                }
            }
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            foreach (String fileName in vmfListBox.Items)
            {
                String propperPath = games[gamesComboBox.SelectedItem.ToString()] + "\\bin\\propper.exe";

                if (!File.Exists(propperPath))
                {
                    if (File.Exists(Application.StartupPath + "\\propper.exe"))
                    {
                        File.Copy(Application.StartupPath + "\\propper.exe", propperPath);
                    } else
                    {
                        MessageBox.Show("Could not find propper.exe");
                        return;
                    }
                }

                String modPath = mods[modsComboBox.SelectedItem.ToString()];

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = propperPath;
                startInfo.Arguments = "-game \"" + modPath + "\" \"" + fileName + "\"";
                Process.Start(startInfo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePaths();
        }

        private void updatePaths()
        {
            loadSteamLibraries();

            loadGames();
        }

        private void loadMods(String game)
        {
            mods = new Dictionary<string, string>();

            KeyVal<string, string> gameConfig = readChunkfile(games[game] + "\\bin\\GameConfig.txt");

            if (gameConfig != null)
            {
                foreach (KeyValuePair<string, KeyVal<string, string>> child in gameConfig.Children["Games"].Children)
                {
                    mods.Add(child.Key, child.Value.Children["GameDir"].Value);
                }
            }

            modsComboBox.Properties.Items.Clear();
            foreach(KeyValuePair<string, string> mod in mods)
            {
                modsComboBox.Properties.Items.Add(mod.Key);
            }

            if (modsComboBox.Properties.Items.Count > 0)
            {
                if (modsComboBox.Properties.Items.Contains(Properties.Settings.Default.selectedMod))
                {
                    modsComboBox.SelectedItem = Properties.Settings.Default.selectedMod;
                }
                else
                {
                    modsComboBox.SelectedIndex = 0;
                    Properties.Settings.Default.selectedMod = modsComboBox.SelectedItem.ToString();
                    Properties.Settings.Default.Save();
                }

                compileButton.Enabled = true;
            } else
            {
                compileButton.Enabled = false;
            }
        }

        private KeyVal<string, string> readChunkfile(String path)
        {
            // Parse Valve chunkfile format
            KeyVal<string, string> root = null;
            Stack<KeyVal<string, string>> children = new Stack<KeyVal<string, string>>();

            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {

                    while (r.Peek() >= 0)
                    {
                        String line = r.ReadLine();
                        line = line.Trim();
                        line = Regex.Replace(line, @"\s+", " ");
                        if (line.StartsWith("//"))
                        {
                            continue;
                        }

                        if (line.Contains("\" \""))
                        {
                            // It's a key value
                            var a = line.Split(new string[] { "\" \"" }, StringSplitOptions.None);
                            var v = new KeyVal<string, string> { Value = a[1].Replace("\"", ""), Children = null };
                            children.Peek().Children.Add(a[0].Replace("\"", ""), v);
                        }
                        else if (line.Contains("\""))
                        {
                            // It's a group
                            line = line.Replace("\"", "");

                            children.Push(new KeyVal<string, string>
                            {
                                Value = line,
                                Children = new Dictionary<string, KeyVal<string, string>>()
                            });
                        }
                        else if (line.Contains("{"))
                        {
                            // It opens a group
                            children.Peek().Children = new Dictionary<string, KeyVal<string, string>>();
                        }
                        else if (line.Contains("}"))
                        {
                            // It closes a group
                            var child = children.Pop();
                            if (children.Count > 0)
                            {
                                String key = child.Value;
                                children.Peek().Children.Add(key, child);
                            }
                            else
                            {
                                root = child;
                            }
                        }


                    }
                }
            }

            return root;
        }

        private void loadGames()
        {
            gamesComboBox.Properties.Items.Clear();
            if (steamLibraries.Count > 0)
            {
                foreach (string library in steamLibraries)
                {
                    foreach (String path in Directory.GetDirectories(library + "\\steamapps\\common\\"))
                    {
                        String game = new FileInfo(path).Name;
                        if (Array.IndexOf(SUPPORTED_GAMES, game.ToLower()) > -1)
                        {
                            games.Add(game, library + "\\steamapps\\common\\" + game);
                        }
                    }
                }

                gamesComboBox.Properties.Items.Clear();
                foreach (KeyValuePair<string, string> game in games)
                {
                    gamesComboBox.Properties.Items.Add(game.Key);
                }

                if (gamesComboBox.Properties.Items.Count > 0)
                {
                    if (gamesComboBox.Properties.Items.Contains(Properties.Settings.Default.selectedGame))
                    {
                        gamesComboBox.SelectedItem = Properties.Settings.Default.selectedGame;
                    }
                    else
                    {
                        gamesComboBox.SelectedIndex = 0;
                        Properties.Settings.Default.selectedGame = gamesComboBox.SelectedItem.ToString();
                        Properties.Settings.Default.Save();
                    }

                }
                else
                {
                    loadMods("");
                }
            }
        }

        class KeyVal<KType, VType>
        {
            public KType Value;
            public Dictionary<KType, KeyVal<KType, VType>> Children;
        }

        private void gamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.selectedGame = gamesComboBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            loadMods(gamesComboBox.SelectedItem.ToString());
        }

        private void modsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.selectedMod = modsComboBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            vmfListBox.Items.Remove(vmfListBox.SelectedItem);
        }

        private void loadSteamLibraries()
        {
            String steamPath = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null).ToString();

            steamLibraries = new List<string>();
            steamLibraries.Add(steamPath);

            KeyVal<string, string> root = readChunkfile(steamPath + "\\steamapps\\libraryfolders.vdf");
            foreach (KeyValuePair<string, KeyVal<string, string>> child in root.Children)
            {
                if (Directory.Exists(child.Value.Value))
                {
                    steamLibraries.Add(child.Value.Value);
                }
            }
        }
    }
}
