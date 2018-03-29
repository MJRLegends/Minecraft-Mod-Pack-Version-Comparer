using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace Minecraft_MJRLegends_Version_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOLDFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select Mod Pack Old Folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtOLDFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select Mod Pack New Folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtNewFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            List<String> oldMods = new List<String>();
            List<String> newMods = new List<String>();
            string filepath = txtOLDFolder.Text + @"\mods\";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.jar"))
            {
                oldMods.Add(file.Name);
            }

            filepath = txtNewFolder.Text + @"\mods\";
            d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.jar"))
            {
                newMods.Add(file.Name);
            }
            for (int i = 0; i < oldMods.Count; i++)
            {
                for (int j = 0; j < newMods.Count; j++)
                {
                    try
                    {
                        String oldMod = oldMods[i];
                        String newMod = newMods[i];
                        if (oldMod != newMod)
                        {
                            if (oldMod.Substring(0, 3) == newMod.Substring(0, 3))
                            {
                                if (!txtOutput.Text.Contains("*Updated " + oldMods[i].Substring(0, oldMods[i].Length - 4) + " to " + newMods[i].Substring(0, newMods[i].Length - 4)))
                                    txtOutput.AppendText("*Updated " + oldMods[i].Substring(0, oldMods[i].Length - 4) + " to " + newMods[i].Substring(0, newMods[i].Length - 4) + "\n");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }
    }
}
