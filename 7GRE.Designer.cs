namespace _7G_Replay_Editor
{
    partial class SGRE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGRE));
            this.lbTitle = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lyviaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.lbBackground = new System.Windows.Forms.Label();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb3 = new System.Windows.Forms.ComboBox();
            this.lbOut2 = new System.Windows.Forms.Label();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.lbOut1 = new System.Windows.Forms.Label();
            this.cbb4 = new System.Windows.Forms.ComboBox();
            this.lbSkybox = new System.Windows.Forms.Label();
            this.cbb5 = new System.Windows.Forms.ComboBox();
            this.lbMusic = new System.Windows.Forms.Label();
            this.cbb6 = new System.Windows.Forms.ComboBox();
            this.lbWeather = new System.Windows.Forms.Label();
            this.cbb7 = new System.Windows.Forms.ComboBox();
            this.lbFirstTr = new System.Windows.Forms.Label();
            this.cbb11 = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbb10 = new System.Windows.Forms.ComboBox();
            this.lbIntro = new System.Windows.Forms.Label();
            this.cbb9 = new System.Windows.Forms.ComboBox();
            this.lbThirdTr = new System.Windows.Forms.Label();
            this.cbb8 = new System.Windows.Forms.ComboBox();
            this.lbSecondTr = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.cbb12 = new System.Windows.Forms.ComboBox();
            this.daliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(193, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(114, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "7G REPLAY EDITOR";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(492, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lyviaffToolStripMenuItem,
            this.daliaToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // lyviaffToolStripMenuItem
            // 
            this.lyviaffToolStripMenuItem.Name = "lyviaffToolStripMenuItem";
            this.lyviaffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lyviaffToolStripMenuItem.Text = "Lyviaff";
            this.lyviaffToolStripMenuItem.Click += new System.EventHandler(this.lyviaffToolStripMenuItem_Click);
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPath.Location = new System.Drawing.Point(166, 62);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(229, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPath_DragEnter);
            // 
            // btBrowse
            // 
            this.btBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBrowse.Location = new System.Drawing.Point(401, 61);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 21);
            this.btBrowse.TabIndex = 3;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(18, 65);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(47, 13);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "File path";
            // 
            // btApply
            // 
            this.btApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btApply.Location = new System.Drawing.Point(401, 393);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 16;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // lbBackground
            // 
            this.lbBackground.AutoSize = true;
            this.lbBackground.Location = new System.Drawing.Point(18, 89);
            this.lbBackground.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBackground.Name = "lbBackground";
            this.lbBackground.Size = new System.Drawing.Size(147, 13);
            this.lbBackground.TabIndex = 6;
            this.lbBackground.Text = "Battle Background Inner Ring";
            // 
            // cbb1
            // 
            this.cbb1.BackColor = System.Drawing.SystemColors.Window;
            this.cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
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
            "4A = C R A S H"});
            this.cbb1.Location = new System.Drawing.Point(166, 86);
            this.cbb1.Margin = new System.Windows.Forms.Padding(2);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(310, 21);
            this.cbb1.TabIndex = 4;
            // 
            // cbb3
            // 
            this.cbb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb3.FormattingEnabled = true;
            this.cbb3.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Nothing",
            "01 = grassy Mountain and sea",
            "02 = Brown smokey mountain with sea",
            "03 = Snowy mountain with sea",
            "04 = desertish mountain with sea",
            "05 = bunch of pathways with sea",
            "06 = ocean with mini islands",
            "07 = Harbor with bots and city",
            "08 = ocean with beach grassy mountain and small island",
            "09 = ocean with beach brown smokey mountain and small island",
            "0A = ocean with beach snowy mountain and small island",
            "0B = ocean with beach desertish mountain and small island",
            "0C = Ocean",
            "0D = Solgaleo Encounter",
            "0E = Lunala Encounter",
            "0F = Half Ocean with some wind above it",
            "10 = Half ocean with some wind above it",
            "11 = Half ocean with some wind above it",
            "12 = Nothing"});
            this.cbb3.Location = new System.Drawing.Point(166, 136);
            this.cbb3.Margin = new System.Windows.Forms.Padding(2);
            this.cbb3.Name = "cbb3";
            this.cbb3.Size = new System.Drawing.Size(310, 21);
            this.cbb3.TabIndex = 6;
            // 
            // lbOut2
            // 
            this.lbOut2.AutoSize = true;
            this.lbOut2.Location = new System.Drawing.Point(18, 139);
            this.lbOut2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOut2.Name = "lbOut2";
            this.lbOut2.Size = new System.Drawing.Size(67, 13);
            this.lbOut2.TabIndex = 11;
            this.lbOut2.Text = "Outer Ring 2";
            // 
            // cbb2
            // 
            this.cbb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Nothing",
            "01 = field with palm trees",
            "02 = field with palm trees and golf course",
            "03 = Mountain cliffs",
            "04 = Waterfall most likely water trial area",
            "05 = Volcanic",
            "06 = Snowy Mountain",
            "07 = Valley",
            "08 = Trees grass and mountain",
            "09 = Poni Meadow",
            "0A = Melemele meadow",
            "0B = Ulaula Meadow",
            "0C = Po Town",
            "0D = Iki Town",
            "0E = some yellow grass area with lots of bushes",
            "0F = city with trees and field on player side",
            "10 = Near Konikoni city probably",
            "11 = Schoolyard",
            "12 = Beach with some trees and rock",
            "13 = Beach with city and chairs",
            "14 = Route 14",
            "15 = dark water with a small island",
            "16 = Aether Foundation Outside",
            "17 = Aether Foundation Conservation Area",
            "18 = Solgaleo Encounter",
            "19 = Lunala Encounter",
            "1A = Battle Tree stairway",
            "1B = Desert",
            "1C = Mountain area",
            "1D = Malie Garden",
            "1E = Ranch area",
            "1F = grassy field with some bushes and cliffs surrounded by a forest of bamboo?",
            "20 = Battle Tree End Top",
            "21 = Battle Tree stairway",
            "22 = Greyish mountain area",
            "23 = Solgaleo/Lunala temple area?",
            "24 = Nothing"});
            this.cbb2.Location = new System.Drawing.Point(166, 111);
            this.cbb2.Margin = new System.Windows.Forms.Padding(2);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(310, 21);
            this.cbb2.TabIndex = 5;
            // 
            // lbOut1
            // 
            this.lbOut1.AutoSize = true;
            this.lbOut1.Location = new System.Drawing.Point(18, 114);
            this.lbOut1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOut1.Name = "lbOut1";
            this.lbOut1.Size = new System.Drawing.Size(116, 13);
            this.lbOut1.TabIndex = 13;
            this.lbOut1.Text = "Outer Ring 1 Research";
            // 
            // cbb4
            // 
            this.cbb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb4.FormattingEnabled = true;
            this.cbb4.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Nothing",
            "01 = Day (Probably based on Sun\'s Time)",
            "02 = Night (Probably based on Moon\'s Time)"});
            this.cbb4.Location = new System.Drawing.Point(166, 161);
            this.cbb4.Margin = new System.Windows.Forms.Padding(2);
            this.cbb4.Name = "cbb4";
            this.cbb4.Size = new System.Drawing.Size(310, 21);
            this.cbb4.TabIndex = 7;
            // 
            // lbSkybox
            // 
            this.lbSkybox.AutoSize = true;
            this.lbSkybox.Location = new System.Drawing.Point(18, 164);
            this.lbSkybox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSkybox.Name = "lbSkybox";
            this.lbSkybox.Size = new System.Drawing.Size(86, 13);
            this.lbSkybox.TabIndex = 15;
            this.lbSkybox.Text = "Skybox research";
            // 
            // cbb5
            // 
            this.cbb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb5.FormattingEnabled = true;
            this.cbb5.Items.AddRange(new object[] {
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
            "E4 = Trainer USUM",
            "FF = None"});
            this.cbb5.Location = new System.Drawing.Point(166, 186);
            this.cbb5.Margin = new System.Windows.Forms.Padding(2);
            this.cbb5.Name = "cbb5";
            this.cbb5.Size = new System.Drawing.Size(310, 21);
            this.cbb5.TabIndex = 8;
            // 
            // lbMusic
            // 
            this.lbMusic.AutoSize = true;
            this.lbMusic.Location = new System.Drawing.Point(18, 189);
            this.lbMusic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(35, 13);
            this.lbMusic.TabIndex = 23;
            this.lbMusic.Text = "Music";
            // 
            // cbb6
            // 
            this.cbb6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb6.FormattingEnabled = true;
            this.cbb6.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Nothing",
            "01 = Sunny",
            "02 = Rain",
            "03 = Hail",
            "04 = Sandstorm",
            "05 = Heavy Rain",
            "06 = Drought",
            "07 = Delta Stream"});
            this.cbb6.Location = new System.Drawing.Point(166, 211);
            this.cbb6.Name = "cbb6";
            this.cbb6.Size = new System.Drawing.Size(310, 21);
            this.cbb6.TabIndex = 9;
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.Location = new System.Drawing.Point(18, 214);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(48, 13);
            this.lbWeather.TabIndex = 27;
            this.lbWeather.Text = "Weather";
            // 
            // cbb7
            // 
            this.cbb7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb7.FormattingEnabled = true;
            this.cbb7.Items.AddRange(new object[] {
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
            "BA+ = Debug Cube"});
            this.cbb7.Location = new System.Drawing.Point(166, 236);
            this.cbb7.Name = "cbb7";
            this.cbb7.Size = new System.Drawing.Size(310, 21);
            this.cbb7.TabIndex = 10;
            // 
            // lbFirstTr
            // 
            this.lbFirstTr.AutoSize = true;
            this.lbFirstTr.Location = new System.Drawing.Point(18, 239);
            this.lbFirstTr.Name = "lbFirstTr";
            this.lbFirstTr.Size = new System.Drawing.Size(90, 13);
            this.lbFirstTr.TabIndex = 29;
            this.lbFirstTr.Text = "First Trainer Class";
            // 
            // cbb11
            // 
            this.cbb11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb11.FormattingEnabled = true;
            this.cbb11.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Wild Battle uses amie/refresh bonuses",
            "01 = Unknown - probably regular trainer battle with amie/refresh bonuses",
            "02 = Battle Tree/Battle Royal or Mock Battle seeing as no amie/refresh bonuses",
            "03 = Wifi"});
            this.cbb11.Location = new System.Drawing.Point(166, 336);
            this.cbb11.Name = "cbb11";
            this.cbb11.Size = new System.Drawing.Size(310, 21);
            this.cbb11.TabIndex = 14;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(16, 339);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(61, 13);
            this.lbType.TabIndex = 43;
            this.lbType.Text = "Battle Type";
            // 
            // cbb10
            // 
            this.cbb10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb10.FormattingEnabled = true;
            this.cbb10.Items.AddRange(new object[] {
            "Don\'t change",
            "00 = Wild Battle",
            "07 = Single Trainer Orange Background",
            "08 = Double Trainer Orange Background",
            "09 = Single Trainer Blue Background",
            "0A = Double Trainer Blue Background",
            "0B = Default Wifi",
            "10 = Trial Captian",
            "11 = Elite 4 Hala",
            "12 = Elite 4 Olivia",
            "13 = Elite 4 Kahili",
            "14 = Elite 4 Acerola",
            "15 = Champion Title Defense Hau",
            "16 = Hau",
            "17 = Hau",
            "18 = Kukui",
            "19 = Gladion",
            "1A = Team Skull special",
            "1B = Hala",
            "1C = Olivia",
            "1D = Nanu",
            "1E = Hapu",
            "1F = Team Skull Grunt single",
            "20 = Team Skull Grunt Double",
            "21 = Team Skull Single",
            "22 = Team Aether Single",
            "23 = Team Aether Double",
            "24 = Team Aether Lusamine",
            "25 = Team Aether Lusamine Fused",
            "27 = Legendary"});
            this.cbb10.Location = new System.Drawing.Point(166, 311);
            this.cbb10.Name = "cbb10";
            this.cbb10.Size = new System.Drawing.Size(310, 21);
            this.cbb10.TabIndex = 13;
            // 
            // lbIntro
            // 
            this.lbIntro.AutoSize = true;
            this.lbIntro.Location = new System.Drawing.Point(17, 314);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(107, 13);
            this.lbIntro.TabIndex = 41;
            this.lbIntro.Text = "Battle Intro Research";
            // 
            // cbb9
            // 
            this.cbb9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb9.FormattingEnabled = true;
            this.cbb9.Items.AddRange(new object[] {
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
            "BA+ = Debug Cube"});
            this.cbb9.Location = new System.Drawing.Point(166, 286);
            this.cbb9.Name = "cbb9";
            this.cbb9.Size = new System.Drawing.Size(310, 21);
            this.cbb9.TabIndex = 12;
            // 
            // lbThirdTr
            // 
            this.lbThirdTr.AutoSize = true;
            this.lbThirdTr.Location = new System.Drawing.Point(18, 289);
            this.lbThirdTr.Name = "lbThirdTr";
            this.lbThirdTr.Size = new System.Drawing.Size(95, 13);
            this.lbThirdTr.TabIndex = 39;
            this.lbThirdTr.Text = "Third Trainer Class";
            // 
            // cbb8
            // 
            this.cbb8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb8.FormattingEnabled = true;
            this.cbb8.Items.AddRange(new object[] {
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
            "BA+ = Debug Cube"});
            this.cbb8.Location = new System.Drawing.Point(166, 261);
            this.cbb8.Name = "cbb8";
            this.cbb8.Size = new System.Drawing.Size(310, 21);
            this.cbb8.TabIndex = 11;
            // 
            // lbSecondTr
            // 
            this.lbSecondTr.AutoSize = true;
            this.lbSecondTr.Location = new System.Drawing.Point(18, 264);
            this.lbSecondTr.Name = "lbSecondTr";
            this.lbSecondTr.Size = new System.Drawing.Size(108, 13);
            this.lbSecondTr.TabIndex = 37;
            this.lbSecondTr.Text = "Second Trainer Class";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(16, 364);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(65, 13);
            this.lbVersion.TabIndex = 45;
            this.lbVersion.Text = "Version type";
            // 
            // cbb12
            // 
            this.cbb12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb12.FormattingEnabled = true;
            this.cbb12.Items.AddRange(new object[] {
            "Don\'t change",
            "65 = Pokémon Sun/Moon version 1.0 (compatible with Citra)",
            "66 = Pokémon Sun/Moon version 1.1",
            "67 = Pokémon Sun/Moon version 1.2",
            "6E = Pokémon Ultra Sun/Moon 1.0 (compatible with Citra)"});
            this.cbb12.Location = new System.Drawing.Point(166, 361);
            this.cbb12.Name = "cbb12";
            this.cbb12.Size = new System.Drawing.Size(310, 21);
            this.cbb12.TabIndex = 15;
            // 
            // daliaToolStripMenuItem
            // 
            this.daliaToolStripMenuItem.Name = "daliaToolStripMenuItem";
            this.daliaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.daliaToolStripMenuItem.Text = "Dalia";
            this.daliaToolStripMenuItem.Click += new System.EventHandler(this.daliaToolStripMenuItem_Click);
            // 
            // SGRE
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 428);
            this.Controls.Add(this.cbb12);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.cbb11);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbb10);
            this.Controls.Add(this.lbIntro);
            this.Controls.Add(this.cbb9);
            this.Controls.Add(this.lbThirdTr);
            this.Controls.Add(this.cbb8);
            this.Controls.Add(this.lbSecondTr);
            this.Controls.Add(this.cbb7);
            this.Controls.Add(this.lbFirstTr);
            this.Controls.Add(this.cbb6);
            this.Controls.Add(this.lbWeather);
            this.Controls.Add(this.cbb5);
            this.Controls.Add(this.lbMusic);
            this.Controls.Add(this.cbb4);
            this.Controls.Add(this.lbSkybox);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.lbOut1);
            this.Controls.Add(this.cbb3);
            this.Controls.Add(this.lbOut2);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.lbBackground);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "SGRE";
            this.Text = "7G Replay Editor - beta";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lyviaffToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label lbBackground;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.ComboBox cbb3;
        private System.Windows.Forms.Label lbOut2;
        private System.Windows.Forms.ComboBox cbb2;
        private System.Windows.Forms.Label lbOut1;
        private System.Windows.Forms.ComboBox cbb4;
        private System.Windows.Forms.Label lbSkybox;
        private System.Windows.Forms.ComboBox cbb5;
        private System.Windows.Forms.Label lbMusic;
        private System.Windows.Forms.ComboBox cbb6;
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.ComboBox cbb7;
        private System.Windows.Forms.Label lbFirstTr;
        private System.Windows.Forms.ComboBox cbb11;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbb10;
        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.ComboBox cbb9;
        private System.Windows.Forms.Label lbThirdTr;
        private System.Windows.Forms.ComboBox cbb8;
        private System.Windows.Forms.Label lbSecondTr;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.ComboBox cbb12;
        private System.Windows.Forms.ToolStripMenuItem daliaToolStripMenuItem;
    }
}

