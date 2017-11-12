using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _7G_Replay_Editor
{
    public partial class SGRE : Form
    {
        public SGRE()
        {
            CheckUpdates();
            InitializeComponent();
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Replay files|";
                openFile.ShowDialog();
                if (Path.GetExtension(openFile.FileNames[0]).ToString() == "" && uint.TryParse(Path.GetFileNameWithoutExtension(openFile.FileNames[0]).ToString(), out uint result) && result < 100)
                {
                    foreach (string filename in openFile.FileNames)
                    {
                        txtPath.Text = filename;
                    }
                    ExecuteRead();
                }
                else
                {
                    MessageBox.Show("Error: following its name and extension, the file you just selected is not a replay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void txtPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            {
                if (Path.GetExtension(files[0]).ToString() == "" && uint.TryParse(Path.GetFileNameWithoutExtension(files[0]).ToString(), out uint result) && result < 100)
                {
                    txtPath.Text = files[0];
                    ExecuteRead();
                }
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if(Directory.Exists("bak\\"))
            {
                File.Copy(txtPath.Text, "bak\\" + Path.GetFileName(txtPath.Text) + "_" + DateTime.Now.ToString().Replace('/', '-').Replace(':', '-').Replace(' ', '_'));
            }
            else
            {
                Directory.CreateDirectory("bak\\");
                File.Copy(txtPath.Text, "bak\\" + Path.GetFileName(txtPath.Text) + "_" + DateTime.Now.ToString().Replace('/', '-').Replace(':', '-').Replace(' ', '_'));
            }
            try
            {
                Edit(0x1EC, cbb1);
                Edit(0x1ED, cbb2);
                Edit(0x1EE, cbb3);
                Edit(0x1EF, cbb4);
                Edit(0x21C, cbb5);
                Edit(0x1FA, cbb6);
                Edit(0x2A48, cbb7);
                Edit(0x2AC0, cbb8);
                Edit(0x2B38, cbb9);
                Edit(0x214, cbb10);
                Edit(0x230, cbb11);
                Edit(0x1D4, cbb12);
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("The replay has successfully been edited!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ExecuteRead()
        {
            ComboBox[] tabCbb = { cbb1, cbb2, cbb3, cbb4, cbb5, cbb6, cbb7, cbb8, cbb9, cbb10, cbb11, cbb12 };
            foreach (ComboBox cbb in tabCbb)
            {
                string item = cbb.Items[cbb.Items.Count - 1].ToString();
                if (item.Contains("UNKNOWN"))
                {
                    cbb.Items.RemoveAt(cbb.Items.Count - 1);
                }
            }
            Read(0x1EC, cbb1);
            Read(0x1ED, cbb2);
            Read(0x1EE, cbb3);
            Read(0x1EF, cbb4);
            Read(0x21C, cbb5);
            Read(0x1FA, cbb6);
            Read(0x2A48, cbb7);
            Read(0x2AC0, cbb8);
            Read(0x2B38, cbb9);
            Read(0x214, cbb10);
            Read(0x230, cbb11);
            Read(0x1D4, cbb12);
        }

        private void Edit(uint hexValue, ComboBox cbb)
        {
            if (cbb.SelectedIndex != 0 && cbb.Text != "")
            {
                using (FileStream fs = File.OpenWrite(txtPath.Text))
                {
                    fs.Seek(hexValue, SeekOrigin.Begin);
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        string value = cbb.Text.Substring(0, 2);
                        writer.Write(StringToByteArray(value));
                    }
                }
            }
        }

        private void Read(uint hexValue, ComboBox cbb)
        {
            using (FileStream fs = File.OpenRead(txtPath.Text))
            {
                fs.Seek(hexValue, SeekOrigin.Begin);
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    byte[] bytes;
                    bytes = reader.ReadBytes(1);
                    string value = BitConverter.ToString(bytes);
                    int index = cbb.FindString(value);
                    cbb.SelectedIndex = index;
                    if (cbb.Text == "")
                    {
                        if(value == null)
                        {
                            cbb.SelectedIndex = 0;
                        }
                        else
                        {
                            cbb.Items.Add(value + " - UNKNOWN");
                            index = cbb.FindString(value);
                            cbb.SelectedIndex = index;
                        }
                    }
                }
            }
        }

        private static void CheckUpdates()
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://lyviaff.kojuri.com/assets/7GREversion.txt");
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = info.FileVersion;
                if (content != version)
                {
                    DialogResult result = MessageBox.Show("An update is available. Do you want to download it?", "An update is available", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://lyviaff.kojuri.com/7g-replay-editor");
                        Environment.Exit(0);
                    }
                }
            }
            catch { }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drag and drop or browse your files with Windows Explorer to open the replay. Once opened, the replay settings are displayed. Then select the settings you want to change and modify them, then validate.\n\nWhen you import your replay, the software sometimes displays \"Unknown\" for an option. In this case, please contact the developer via his website or via Twitter to let him know and make him able to update the software.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void lyviaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This program has been developed by Lyviaff. Do you want to show him Twitter?", "Lyviaff", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.Twitter.com/Lyviaff");
            }
        }

        private void daliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("He helped the developer by testing each hex value corresponding to each music. Do you want to show him Twitter?", "Dalia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.Twitter.com/DaliaAsTrue");
            }
        }
    }
}