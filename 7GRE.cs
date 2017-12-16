using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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
            try
            {
                if (Directory.Exists("bak\\"))
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
                ExecuteRead();
                MessageBox.Show("The replay has successfully been edited!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
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
            if (cbb12.Text != null && cbb12.Text != "" && cbb12.Text != "Don\'t change")
            {
                AddToCbb(cbb1, cbb1Content, "4B = Autumn House");
                AddToCbb(cbb5, cbb5Content, "FF = None");
                AddToCbb(cbb7, cbb789Content, "BA = Sophicles");
                AddToCbb(cbb8, cbb789Content, "BA = Sophicles");
                AddToCbb(cbb9, cbb789Content, "BA = Sophicles");
            }
        }

        private void AddToCbb(ComboBox cbb, string[] board, string exclusion)
        {
            bool isUnknown = false;
            if (cbb12.Text.Substring(0, 2) == "65" || cbb12.Text.Substring(0, 2) == "66" || cbb12.Text.Substring(0, 2) == "67")
            {
                string value = cbb.Text.Substring(0, 2);
                if (cbb.Text.Contains("UNKNOWN"))
                    isUnknown = true;
                cbb.Items.Clear();
                foreach (string item in board)
                {
                    if (item != exclusion)
                        cbb.Items.Add(item);
                    else
                        break;
                }

                if (isUnknown)
                {
                    cbb.Items.Add(value + " - UNKNOWN");
                    cbb.SelectedIndex = cbb.Items.Count -1;
                }
                else
                {
                    int index = cbb.FindString(value);
                    cbb.SelectedIndex = index;
                }
            }
            else
            {
                string value = cbb.Text.Substring(0, 2);
                if (cbb.Text.Contains("UNKNOWN"))
                    isUnknown = true;
                cbb.Items.Clear();
                foreach (string item in board)
                    cbb.Items.Add(item);
                if (isUnknown)
                {
                    cbb.Items.Add(value + " - UNKNOWN");
                    cbb.SelectedIndex = cbb.Items.Count -1;
                }
                else
                {
                    int index = cbb.FindString(value);
                    cbb.SelectedIndex = index;
                }
            }
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
                        if (value == null)
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
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/Lyviaff/7G-Replay-Editor/master/changelog.txt");
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                string[] contentSplitted = content.Split('/');
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = info.FileVersion;
                if (contentSplitted[0] != version)
                {
                    DialogResult result = MessageBox.Show("7G Replay Editor " + contentSplitted[0] + " is available.\nDo you want to download it?\n\n\nChangelog:\n" + contentSplitted[1], "An update is available", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://lyviaff.kojuri.com/7g-replay-editor");
                        Environment.Exit(0);
                    }
                }
            }
            catch { }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drag and drop or browse your files with Windows Explorer to open the replay. Once opened, the replay settings are displayed. Then select the settings you want to change and modify them, then validate.\n\nWhen you import your replay, the software sometimes displays \"Unknown\" for an option. In this case, please contact the developer via his website or via Twitter to let him know and make him able to update the software.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7G Replay Editor v.1.1:\n\n- Changed the changelog file used to check for updates\n- Added support for version 1.1 of Pokémon USUM", "Changelog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void lyviaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This program has been developed by Lyviaff. Do you want to show him Twitter?", "Lyviaff", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.Twitter.com/Lyviaff");
            }
        }

        string[] cbb1Content = {
            "Don\'t change",
            "00 = Nothing",
            "01 = Some Route Grass",
            "02 = Field with little flowers",
            "03 = Forest",
            "04 = Mountainish area",
            "05 = Some Mountainish area ",
            "06 = Volcanic Area",
            "07 = Probably Mountian before Elite 4",
            "08 = Valley mountain area",
            "09 = Cemetery",
            "0A = Abandoned Poke Mart (Ghost Trial Area)",
            "0B = Mountainish with some grass",
            "0C = Tall grass with some rocks",
            "0D = Melemele Meadow",
            "0E = Route 6",
            "0F = Po Town",
            "10 = Iki Town Festival Platform",
            "11 = Paniola Town",
            "12 = Hau\'oli city Marina Day",
            "13 = Konikoni City ",
            "14 = Some Street probably route 8",
            "15 = Sand or beach",
            "16 = Beach with forest and some cliffs",
            "17 = Beach with chairs and stuff",
            "18 = Route 14 beach area",
            "19 = Water with grass around it",
            "1A = Water with rocks around",
            "1B = Cave",
            "1C = Cave with water",
            "1D = one of the Tapu Areas",
            "1E = Generic Indoor area",
            "1F = Totem Mimikyu arena",
            "20 = Classroom",
            "21 = Po Town Team Skull Base",
            "22 = Verdant Cavern (First Trial Area)",
            "23 = Elite 4 Hala",
            "24 = Elite 4 Olivia",
            "25 = Elite 4 Acerola",
            "26 = Elite 4 Kahili",
            "27 = Champion",
            "28 = Snowy Field",
            "29 = Aether Foundation Hallway",
            "2A = Aether Foundation Conservation Area",
            "2B = Solgaleo Encounter",
            "2C = Lunala Encounter",
            "2D = Ultra Space",
            "2E = Battle Tree stairs",
            "2F = Battle Royal",
            "30 = Default Wifi",
            "31 = World Championship",
            "32 = World Championship Finals",
            "33 = Misty Terrain",
            "34 = Electric Terrain",
            "35 = Grassy Terrain",
            "36 = Psychic Terrain",
            "37 = Lush Jungle",
            "38 = Desert",
            "39 = Mountain/Cave area",
            "3A = Route 10 Mountain road",
            "3B = Some route with fences and palm trees",
            "3C = Seafolk Village/Docks",
            "3D = Malie Garden?",
            "3E = Lush Jungle with tall grass around",
            "3F = Preservation Room",
            "40 = Some Cave frosty maybe",
            "41 = Field of Grass",
            "42 = Yellow grass with rocks",
            "43 = Malie Garden Again?",
            "44 = Battle Tree End Top",
            "45 = Battle Tree Battle Legend?",
            "46 = Grey Mountainish area with rocks",
            "47 = Some Solgaleo Temple",
            "48 = Solgaleo encounter with Lillie in background",
            "49 = Lunala encounter with Lillie in background",
            "4A = C R A S H",
            "4B = Autumn House",
            "4C = Underwater",
            "4D = Ruins",
            "4E = Place with fir trees",
            "50 = Hearts",
            "51 = Space",
            "53 = What the fuck? (seems to be an illuminati tournament)",
            "54 = What the fuck?? (seems to be a party)",
            "55 = Mahalo Mountain Trail",
            "56 = Ultra Wormhole",
            "57 = Battle Agency",
            "58 = Ultra Megalopolis",
            "59 = Elite 4 Molayne",
            "5A = Rainbow Rocket Sbire",
            "5B = Rainbow Rocket Giovanni",
            "5C = Last Trial Captain",
            "5D = Route 1",
            "5E = Rainbow Rocket Boss",
            "5F = Mahalo Trail",
            "4F = C R A S H"};

        string[] cbb5Content = {
            "Don\'t change",
            "4B = Wild Pokémon SM",
            "4C = Test",
            "4D = Trainer SM",
            "4E = Island Kahuna",
            "4F = My Friend Hau",
            "50 = Gladion",
            "51 = Team Skull",
            "52 = Team Skull Admin",
            "53 = Team Skull Boss",
            "54 = Aether Foundation",
            "55 = Lusamine, Version 1",
            "56 = Lusamine, Version 2",
            "57 = Enter the Ultra Beasts",
            "58 = Elite Four",
            "59 = League Title Defense",
            "5A = Guardian Deity",
            "5B = Legendary Pokémon",
            "5C = VS Red/Green",
            "5D = Battle Royal",
            "5E = World Champion Ships",
            "A0 = Cynthia",
            "A9 = XY",
            "AA = Elite 4 BW",
            "AB = Wally ORAS",
            "AC = Colress",
            "FF = None",
            "B8 = ?",
            "B9 = ?",
            "BA = Wild Pokemon USUM",
            "BB = ?",
            "BC = ?",
            "BD = ?",
            "BE = ?",
            "BF = ?",
            "C0 = ?",
            "C1 = ?",
            "C2 = Team Rainbow Rocket Hideout",
            "C3 = Team Rainbow Rocket Hideout 2",
            "C4 = Team Rainbow Rocket Admin",
            "C5 = Team Rainbow Rocket Giovanni",
            "C6 = Team Aqua/Magma Admins",
            "C7 = Team Galaxy Cyrus",
            "C8 = Team Plasma Ghetsis",
            "C9 = Team Flare Lysandre",
            "CA = Ultra-Commando",
            "CB = Final Necrozma Encounter",
            "CC = Necrozma Encounter",
            "CD = Kinematic",
            "CE = ?",
            "D2 = ?",
            "D3 = ?",
            "D4 = Legendary Trio XY",
            "D5 = Wild Pokemon R/B/Y",
            "D6 = Wild Pokemon R/S/E",
            "D7 = Legendary R/S/E",
            "D8 = Legendary Trio R/S/E",
            "D9 = Legendary Ho-Oh",
            "DA = Legendary Lugia",
            "DB = Legendary Trio O/A/C",
            "DC = Legendary Trio D/P/Pt",
            "DD = Legendary D/P",
            "DE = Legendary Fabulous D/P",
            "DF = Legendary Giratina",
            "E0 = Legendary Trio BW",
            "E1 = Legendary BW",
            "E2 = Rainbow Rocket Sbire",
            "E3 = Legendary XY",
            "E4 = Trainer USUM"};

        string[] cbb789Content = {
            "Don\'t change",
            "00 = Debug Cube",
            "01 = Lillie",
            "01 01 = Z-Powered Lillie",
            "02 = Youngster",
            "03 = Lass",
            "04 = Ace Trainer (Female)",
            "05 = Ace Trainer (Male)",
            "06 = Preschooler (Girl)",
            "07 = Preschooler (Boy)",
            "08 = Beauty",
            "09 = Swimmer (Male)",
            "0A = Black Belt",
            "0B = Scientist",
            "0C = Punk Guy",
            "0D = Backpacker",
            "0E = Punk Girl",
            "0F = Sightseer (Female)",
            "10 = Sightseer (Male)",
            "11 = Swimmer (Female)",
            "12 = Veteran (Female)",
            "13 = Veteran (Male)",
            "14 = Rising Star (Female)",
            "15 = Rising Star (Male)",
            "16 = Madame",
            "17 = Gentleman",
            "18 = Hiker",
            "19 = Collector",
            "1A = Pokemon Breeder (Male)",
            "1B = Pokemon Breeder (Female)",
            "1C = Team Skull Grunt (Male)",
            "1D = Team Skull Grunt (Female)",
            "1E = Hau",
            "1F = Hala",
            "20 = Office Worker (Female)",
            "21 = Youth Athlete(Male)",
            "22 = Youth Athlete (Female)",
            "23 = Swimmer (Female) yellow bikini and different hair",
            "24 = Office Worker (Male)",
            "25 = Teacher",
            "26 = Ilima",
            "27 = Trial Guide (Female)",
            "28 = Collector",
            "29 = Office Worker (Male)",
            "2A = Trial Guide (Male)",
            "2B = Mallow",
            "2C = Lana",
            "2D = Kiawe",
            "2E = Mina",
            "2F = Acerola",
            "30 = Sophocles",
            "31 = Olivia",
            "32 = Nanu",
            "33 = Hapu",
            "34 = Police Officer",
            "35 = Dancer",
            "36 = Cook",
            "37 = Bellhop",
            "38 = Firefighter",
            "39 = Janitor",
            "3A = Worker",
            "3B = Fisherman",
            "3C = Golfer (Male)",
            "3D = Golfer (Female)",
            "3E = Preschooler (Female)",
            "3F = Rising Star (Male)",
            "40 =  Ace Trainer (Male)",
            "41 = Veteran (Male)",
            "42 = Sightseer (Male)",
            "43 = Swimmer (Male)",
            "44 = Punk Guy",
            "45 = Team Skull Lass???",
            "46 = Gladion",
            "47 = Lusamine",
            "48 = Faba",
            "49 = Aether Foundation (Male)",
            "4A = Aether Foundation (Female)",
            "4B = Aether Foundation (Masked)",
            "4C = Guzma",
            "4D = Guzma (Ex Team Skull)",
            "4E = Plumeria",
            "4F = Plumeria (Ex Team Skull)",
            "50 = Kahili",
            "51 = Ryuki",
            "52 = Lusamine (Beast Fused)",
            "53 = Red",
            "54 = Blue",
            "55 = Sina",
            "56 = Dexio",
            "57 = Grimsley",
            "58 = Sina",
            "59 = Dexio",
            "5A = Grimsley",
            "5B = Cynthia",
            "5C = The Royal",
            "5D = Molayne",
            "5E = Pokemon Center Lady",
            "5F = Fisherman",
            "60 = Aether Foundation (Female) Alt",
            "61 = Sina",
            "62 = Dexio",
            "63 = Molayne",
            "64 = Hau",
            "65 = Hau",
            "66 = Gladion",
            "67 = Gladion",
            "68 = Ilima",
            "69 = Kiawe",
            "6A = Lana",
            "6B = Acerola",
            "6C = Mina",
            "6D = Hala",
            "6E = Olivia",
            "6F = Kukui",
            "70 = Rising Star (Female)",
            "71 = Ace Trainer (Female)",
            "72 = Veteran (Female)",
            "73 = Sightseer (Female)",
            "74 = Swimmer (Female)",
            "75 = Preschooler (Boy)",
            "76 = Black Belt",
            "77 = Ace Trainer (Female)",
            "78 = Ace Trainer (Male)",
            "79 = Veteran (Female)",
            "7A = Veteran (Male)",
            "7B = Black Belt",
            "7C = Collector",
            "7D = Trial Guide (Female)",
            "7E = Trial Guide (Male)",
            "7F = Youngster",
            "80 = Plumeria (Ex Team Skull)",
            "81 = Principal",
            "82 = Flareon User",
            "83 = Espeon User",
            "84 = Leafeon User",
            "85 = Sylveon User",
            "86 = Eevee User",
            "87 = Umbreon User",
            "88 = Vaporeon User",
            "89 = Jolteon User",
            "8A = Glaceon User",
            "8B = GAME FREAK",
            "8C = Guzma (Ex Team Skull)",
            "8D = Nanu",
            "8E = Sophocles",
            "8F = Ryuki",
            "90 = Punk Girl",
            "91 = Youth Athlete (Male)",
            "92 = Youth Athlete (Female)",
            "93 = Swimmer (Female)",
            "94 = Swimmer (Female) yellow bikini and different hair",
            "95 = Golfer (Female)",
            "96 = Acerola",
            "97 = IIlima",
            "98 = Lana",
            "99 = Mina",
            "9A = Kukui",
            "9B = Ace Trainer (Female)",
            "9C = Ace Trainer (Male)",
            "9D = Rising Star (Female)",
            "9E = Rising Star (Male)",
            "9F = Youngster",
            "A1 = Pokemon Breeder",
            "A2 = Faba",
            "A3 = Youngster",
            "A4 = Hapu",
            "A5 = Kukui",
            "A6 = Sina",
            "A7 = Grimsley",
            "A8 = Wally",
            "A9 = Colress",
            "AA = Cynthia",
            "AB = Anabel",
            "AC = Twins",
            "AD = Rising Star Duo",
            "AE = Punk Pair",
            "AF = Karate Family",
            "B1 = Ace Duo",
            "B2 = Honeymooners",
            "B3 = Veteran Duo",
            "B4 = Athletic Siblings",
            "B5 = Swimmer Girls",
            "B6 = Golf Buddies",
            "B7 = Red",
            "B8 = Blue",
            "B9 = Faba",
            "BA = Sophicles",
            "BB = Giovanni",
            "BC = Professor Kakui with z ring",
            "BD = Z-powered Lillie",
            "BE = Giovanni Again",
            "BF = Molayne",
            "C0 = Soliera",
            "C1 = Dulse",
            "C2 = Hau with z ring",
            "C3 = Surfer",
            "C4 = Actor",
            "C5 = Reporter",
            "C6 = Archie",
            "C7 = Cyrus",
            "C8 = Maxie",
            "C9 = Ghetsis",
            "CA = Lysandre",
            "CB = Kantonian Gym (Beauty",
            "CC = Kantonian Gym (Black Belt)",
            "CD = GAME FREAK (Unique Black Belt)",
            "CE = Z-Powered Lillie Again",
            "CF = Team Rainbow Rocket Grunt (Male)",
            "D0 = Team Rainbow Rocket Grunt (Female)",
            "D1 = Ultra Forest",
            "D2 = Master & Apprentice",
            "D3 = Dancing Family",
            "D4 = Capoeira Couple",
            "D5 = Tourist Couple",
            "D6 = Sparring Partners",
            "D7 = Office Worker",
            "D8 = Dancer",
            "D9 = Bellhop",
            "DA = Guzma (Ex Team-Skull) with z ring it seems",
            "DB = Aether President Lusamine",
            "DC = Hau with z ring again",
            "DD = Hau with z ring again",
            "DE+ = Debug Model"};
    }
}