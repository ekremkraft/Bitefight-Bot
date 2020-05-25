namespace BitefightProject
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupAccountSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblServers = new System.Windows.Forms.Label();
            this.comboServers = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Emulator = new System.Windows.Forms.WebBrowser();
            this.groupAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblCharismaCost = new System.Windows.Forms.Label();
            this.lblEnduranceCost = new System.Windows.Forms.Label();
            this.lblDexterityCost = new System.Windows.Forms.Label();
            this.lblDefenceCost = new System.Windows.Forms.Label();
            this.lblForceCost = new System.Windows.Forms.Label();
            this.lblFightValue = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHerz = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblResSplinters = new System.Windows.Forms.Label();
            this.lblRes3 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.groupPlay = new System.Windows.Forms.GroupBox();
            this.lblAPLimit2 = new System.Windows.Forms.Label();
            this.txtAPLimit2 = new System.Windows.Forms.TextBox();
            this.checkAutoCure = new System.Windows.Forms.CheckBox();
            this.groupGraveyard = new System.Windows.Forms.GroupBox();
            this.lblGraveyardCount = new System.Windows.Forms.Label();
            this.txtGraveyardCount = new System.Windows.Forms.TextBox();
            this.comboGraveyard = new System.Windows.Forms.ComboBox();
            this.checkGraveyard = new System.Windows.Forms.CheckBox();
            this.groupGrotte = new System.Windows.Forms.GroupBox();
            this.lblGrotteCount = new System.Windows.Forms.Label();
            this.txtGrotteCount = new System.Windows.Forms.TextBox();
            this.comboGrotte = new System.Windows.Forms.ComboBox();
            this.checkGrotte = new System.Windows.Forms.CheckBox();
            this.groupHumanHunt = new System.Windows.Forms.GroupBox();
            this.lblHumanHuntCount = new System.Windows.Forms.Label();
            this.txtHumanHuntCount = new System.Windows.Forms.TextBox();
            this.comboHumanHunt = new System.Windows.Forms.ComboBox();
            this.checkHumanHunt = new System.Windows.Forms.CheckBox();
            this.checkPlayerVsPlayer = new System.Windows.Forms.CheckBox();
            this.lblAPLimit = new System.Windows.Forms.Label();
            this.txtAPLimit = new System.Windows.Forms.TextBox();
            this.checkAutoStat = new System.Windows.Forms.CheckBox();
            this.checkStory = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerAccountInfo = new System.Windows.Forms.Timer(this.components);
            this.groupLogs = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listLogs = new System.Windows.Forms.ListView();
            this.columnAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmulatorLogin = new System.Windows.Forms.WebBrowser();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.EmulatorGoldAPFeature = new System.Windows.Forms.WebBrowser();
            this.EmulatorUsingStat = new System.Windows.Forms.WebBrowser();
            this.EmulatorPlayerVsPlayer = new System.Windows.Forms.WebBrowser();
            this.EmulatorHumanHunt = new System.Windows.Forms.WebBrowser();
            this.EmulatorGrotte = new System.Windows.Forms.WebBrowser();
            this.EmulatorGraveyard = new System.Windows.Forms.WebBrowser();
            this.timerGraveyardWait = new System.Windows.Forms.Timer(this.components);
            this.EmulatorCure = new System.Windows.Forms.WebBrowser();
            this.timerAutoCure = new System.Windows.Forms.Timer(this.components);
            this.groupAccountSettings.SuspendLayout();
            this.groupAccountInfo.SuspendLayout();
            this.groupPlay.SuspendLayout();
            this.groupGraveyard.SuspendLayout();
            this.groupGrotte.SuspendLayout();
            this.groupHumanHunt.SuspendLayout();
            this.groupLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAccountSettings
            // 
            this.groupAccountSettings.Controls.Add(this.label1);
            this.groupAccountSettings.Controls.Add(this.btnConnect);
            this.groupAccountSettings.Controls.Add(this.lblVersion);
            this.groupAccountSettings.Controls.Add(this.btnAdd);
            this.groupAccountSettings.Controls.Add(this.btnEdit);
            this.groupAccountSettings.Controls.Add(this.btnDelete);
            this.groupAccountSettings.Controls.Add(this.lblServers);
            this.groupAccountSettings.Controls.Add(this.comboServers);
            this.groupAccountSettings.Location = new System.Drawing.Point(12, 12);
            this.groupAccountSettings.Name = "groupAccountSettings";
            this.groupAccountSettings.Size = new System.Drawing.Size(444, 77);
            this.groupAccountSettings.TabIndex = 0;
            this.groupAccountSettings.TabStop = false;
            this.groupAccountSettings.Text = "Account Settings - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "bitefighteasy.blogspot.com";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(381, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(57, 21);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(97, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(201, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(282, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Location = new System.Drawing.Point(6, 22);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(38, 13);
            this.lblServers.TabIndex = 2;
            this.lblServers.Text = "Server";
            // 
            // comboServers
            // 
            this.comboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServers.FormattingEnabled = true;
            this.comboServers.Location = new System.Drawing.Point(65, 19);
            this.comboServers.Name = "comboServers";
            this.comboServers.Size = new System.Drawing.Size(310, 21);
            this.comboServers.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 307);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 20);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Emulator
            // 
            this.Emulator.Location = new System.Drawing.Point(511, 58);
            this.Emulator.MinimumSize = new System.Drawing.Size(20, 20);
            this.Emulator.Name = "Emulator";
            this.Emulator.Size = new System.Drawing.Size(47, 40);
            this.Emulator.TabIndex = 2;
            this.Emulator.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Emulator_DocumentCompleted);
            // 
            // groupAccountInfo
            // 
            this.groupAccountInfo.Controls.Add(this.lblCharismaCost);
            this.groupAccountInfo.Controls.Add(this.lblEnduranceCost);
            this.groupAccountInfo.Controls.Add(this.lblDexterityCost);
            this.groupAccountInfo.Controls.Add(this.lblDefenceCost);
            this.groupAccountInfo.Controls.Add(this.lblForceCost);
            this.groupAccountInfo.Controls.Add(this.lblFightValue);
            this.groupAccountInfo.Controls.Add(this.lblLevel);
            this.groupAccountInfo.Controls.Add(this.lblHerz);
            this.groupAccountInfo.Controls.Add(this.lblAP);
            this.groupAccountInfo.Controls.Add(this.lblResSplinters);
            this.groupAccountInfo.Controls.Add(this.lblRes3);
            this.groupAccountInfo.Controls.Add(this.lblRes2);
            this.groupAccountInfo.Location = new System.Drawing.Point(12, 95);
            this.groupAccountInfo.Name = "groupAccountInfo";
            this.groupAccountInfo.Size = new System.Drawing.Size(171, 206);
            this.groupAccountInfo.TabIndex = 3;
            this.groupAccountInfo.TabStop = false;
            this.groupAccountInfo.Text = "Account Info";
            // 
            // lblCharismaCost
            // 
            this.lblCharismaCost.AutoSize = true;
            this.lblCharismaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharismaCost.Location = new System.Drawing.Point(6, 181);
            this.lblCharismaCost.Name = "lblCharismaCost";
            this.lblCharismaCost.Size = new System.Drawing.Size(74, 13);
            this.lblCharismaCost.TabIndex = 16;
            this.lblCharismaCost.Text = "Charisma Cost";
            // 
            // lblEnduranceCost
            // 
            this.lblEnduranceCost.AutoSize = true;
            this.lblEnduranceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnduranceCost.Location = new System.Drawing.Point(6, 166);
            this.lblEnduranceCost.Name = "lblEnduranceCost";
            this.lblEnduranceCost.Size = new System.Drawing.Size(83, 13);
            this.lblEnduranceCost.TabIndex = 15;
            this.lblEnduranceCost.Text = "Endurance Cost";
            // 
            // lblDexterityCost
            // 
            this.lblDexterityCost.AutoSize = true;
            this.lblDexterityCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexterityCost.Location = new System.Drawing.Point(6, 151);
            this.lblDexterityCost.Name = "lblDexterityCost";
            this.lblDexterityCost.Size = new System.Drawing.Size(72, 13);
            this.lblDexterityCost.TabIndex = 14;
            this.lblDexterityCost.Text = "Dexterity Cost";
            // 
            // lblDefenceCost
            // 
            this.lblDefenceCost.AutoSize = true;
            this.lblDefenceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefenceCost.Location = new System.Drawing.Point(6, 136);
            this.lblDefenceCost.Name = "lblDefenceCost";
            this.lblDefenceCost.Size = new System.Drawing.Size(72, 13);
            this.lblDefenceCost.TabIndex = 13;
            this.lblDefenceCost.Text = "Defence Cost";
            // 
            // lblForceCost
            // 
            this.lblForceCost.AutoSize = true;
            this.lblForceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForceCost.Location = new System.Drawing.Point(6, 121);
            this.lblForceCost.Name = "lblForceCost";
            this.lblForceCost.Size = new System.Drawing.Size(58, 13);
            this.lblForceCost.TabIndex = 12;
            this.lblForceCost.Text = "Force Cost";
            // 
            // lblFightValue
            // 
            this.lblFightValue.AutoSize = true;
            this.lblFightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFightValue.Location = new System.Drawing.Point(6, 106);
            this.lblFightValue.Name = "lblFightValue";
            this.lblFightValue.Size = new System.Drawing.Size(63, 13);
            this.lblFightValue.TabIndex = 11;
            this.lblFightValue.Text = "Battle value";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(6, 91);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level";
            // 
            // lblHerz
            // 
            this.lblHerz.AutoSize = true;
            this.lblHerz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerz.Location = new System.Drawing.Point(6, 76);
            this.lblHerz.Name = "lblHerz";
            this.lblHerz.Size = new System.Drawing.Size(38, 13);
            this.lblHerz.TabIndex = 9;
            this.lblHerz.Text = "Health";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(6, 61);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(68, 13);
            this.lblAP.TabIndex = 8;
            this.lblAP.Text = "Action points";
            // 
            // lblResSplinters
            // 
            this.lblResSplinters.AutoSize = true;
            this.lblResSplinters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResSplinters.Location = new System.Drawing.Point(6, 46);
            this.lblResSplinters.Name = "lblResSplinters";
            this.lblResSplinters.Size = new System.Drawing.Size(56, 13);
            this.lblResSplinters.TabIndex = 7;
            this.lblResSplinters.Text = "Fragments";
            // 
            // lblRes3
            // 
            this.lblRes3.AutoSize = true;
            this.lblRes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes3.Location = new System.Drawing.Point(6, 31);
            this.lblRes3.Name = "lblRes3";
            this.lblRes3.Size = new System.Drawing.Size(56, 13);
            this.lblRes3.TabIndex = 6;
            this.lblRes3.Text = "Hellstones";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes2.Location = new System.Drawing.Point(6, 16);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(29, 13);
            this.lblRes2.TabIndex = 5;
            this.lblRes2.Text = "Gold";
            // 
            // groupPlay
            // 
            this.groupPlay.Controls.Add(this.lblAPLimit2);
            this.groupPlay.Controls.Add(this.txtAPLimit2);
            this.groupPlay.Controls.Add(this.checkAutoCure);
            this.groupPlay.Controls.Add(this.groupGraveyard);
            this.groupPlay.Controls.Add(this.groupGrotte);
            this.groupPlay.Controls.Add(this.groupHumanHunt);
            this.groupPlay.Controls.Add(this.checkPlayerVsPlayer);
            this.groupPlay.Controls.Add(this.lblAPLimit);
            this.groupPlay.Controls.Add(this.txtAPLimit);
            this.groupPlay.Controls.Add(this.checkAutoStat);
            this.groupPlay.Controls.Add(this.checkStory);
            this.groupPlay.Location = new System.Drawing.Point(189, 95);
            this.groupPlay.Name = "groupPlay";
            this.groupPlay.Size = new System.Drawing.Size(267, 232);
            this.groupPlay.TabIndex = 4;
            this.groupPlay.TabStop = false;
            this.groupPlay.Text = "Play";
            // 
            // lblAPLimit2
            // 
            this.lblAPLimit2.AutoSize = true;
            this.lblAPLimit2.Location = new System.Drawing.Point(112, 44);
            this.lblAPLimit2.Name = "lblAPLimit2";
            this.lblAPLimit2.Size = new System.Drawing.Size(41, 13);
            this.lblAPLimit2.TabIndex = 21;
            this.lblAPLimit2.Text = "AP limit";
            // 
            // txtAPLimit2
            // 
            this.txtAPLimit2.Enabled = false;
            this.txtAPLimit2.Location = new System.Drawing.Point(79, 40);
            this.txtAPLimit2.MaxLength = 3;
            this.txtAPLimit2.Name = "txtAPLimit2";
            this.txtAPLimit2.Size = new System.Drawing.Size(27, 20);
            this.txtAPLimit2.TabIndex = 20;
            this.txtAPLimit2.Text = "5";
            // 
            // checkAutoCure
            // 
            this.checkAutoCure.AutoSize = true;
            this.checkAutoCure.Enabled = false;
            this.checkAutoCure.Location = new System.Drawing.Point(6, 43);
            this.checkAutoCure.Name = "checkAutoCure";
            this.checkAutoCure.Size = new System.Drawing.Size(73, 17);
            this.checkAutoCure.TabIndex = 19;
            this.checkAutoCure.Text = "Auto Cure";
            this.checkAutoCure.UseVisualStyleBackColor = true;
            // 
            // groupGraveyard
            // 
            this.groupGraveyard.Controls.Add(this.lblGraveyardCount);
            this.groupGraveyard.Controls.Add(this.txtGraveyardCount);
            this.groupGraveyard.Controls.Add(this.comboGraveyard);
            this.groupGraveyard.Controls.Add(this.checkGraveyard);
            this.groupGraveyard.Enabled = false;
            this.groupGraveyard.Location = new System.Drawing.Point(6, 178);
            this.groupGraveyard.Name = "groupGraveyard";
            this.groupGraveyard.Size = new System.Drawing.Size(255, 45);
            this.groupGraveyard.TabIndex = 18;
            this.groupGraveyard.TabStop = false;
            this.groupGraveyard.Text = "Graveyard";
            // 
            // lblGraveyardCount
            // 
            this.lblGraveyardCount.AutoSize = true;
            this.lblGraveyardCount.Location = new System.Drawing.Point(178, 0);
            this.lblGraveyardCount.Name = "lblGraveyardCount";
            this.lblGraveyardCount.Size = new System.Drawing.Size(35, 13);
            this.lblGraveyardCount.TabIndex = 10;
            this.lblGraveyardCount.Text = "Count";
            // 
            // txtGraveyardCount
            // 
            this.txtGraveyardCount.Location = new System.Drawing.Point(181, 17);
            this.txtGraveyardCount.MaxLength = 3;
            this.txtGraveyardCount.Multiline = true;
            this.txtGraveyardCount.Name = "txtGraveyardCount";
            this.txtGraveyardCount.Size = new System.Drawing.Size(43, 21);
            this.txtGraveyardCount.TabIndex = 15;
            this.txtGraveyardCount.Text = "1";
            // 
            // comboGraveyard
            // 
            this.comboGraveyard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGraveyard.FormattingEnabled = true;
            this.comboGraveyard.Items.AddRange(new object[] {
            "1:00:00",
            "2:00:00",
            "3:00:00",
            "4:00:00",
            "5:00:00",
            "6:00:00",
            "7:00:00",
            "8:00:00"});
            this.comboGraveyard.Location = new System.Drawing.Point(8, 17);
            this.comboGraveyard.Name = "comboGraveyard";
            this.comboGraveyard.Size = new System.Drawing.Size(167, 21);
            this.comboGraveyard.TabIndex = 10;
            // 
            // checkGraveyard
            // 
            this.checkGraveyard.AutoSize = true;
            this.checkGraveyard.Location = new System.Drawing.Point(65, 0);
            this.checkGraveyard.Name = "checkGraveyard";
            this.checkGraveyard.Size = new System.Drawing.Size(15, 14);
            this.checkGraveyard.TabIndex = 14;
            this.checkGraveyard.UseVisualStyleBackColor = true;
            this.checkGraveyard.CheckedChanged += new System.EventHandler(this.checkGraveyard_CheckedChanged);
            // 
            // groupGrotte
            // 
            this.groupGrotte.Controls.Add(this.lblGrotteCount);
            this.groupGrotte.Controls.Add(this.txtGrotteCount);
            this.groupGrotte.Controls.Add(this.comboGrotte);
            this.groupGrotte.Controls.Add(this.checkGrotte);
            this.groupGrotte.Enabled = false;
            this.groupGrotte.Location = new System.Drawing.Point(6, 76);
            this.groupGrotte.Name = "groupGrotte";
            this.groupGrotte.Size = new System.Drawing.Size(255, 45);
            this.groupGrotte.TabIndex = 17;
            this.groupGrotte.TabStop = false;
            this.groupGrotte.Text = "Grotte";
            // 
            // lblGrotteCount
            // 
            this.lblGrotteCount.AutoSize = true;
            this.lblGrotteCount.Enabled = false;
            this.lblGrotteCount.Location = new System.Drawing.Point(178, 0);
            this.lblGrotteCount.Name = "lblGrotteCount";
            this.lblGrotteCount.Size = new System.Drawing.Size(35, 13);
            this.lblGrotteCount.TabIndex = 10;
            this.lblGrotteCount.Text = "Count";
            // 
            // txtGrotteCount
            // 
            this.txtGrotteCount.Enabled = false;
            this.txtGrotteCount.Location = new System.Drawing.Point(181, 17);
            this.txtGrotteCount.MaxLength = 3;
            this.txtGrotteCount.Multiline = true;
            this.txtGrotteCount.Name = "txtGrotteCount";
            this.txtGrotteCount.Size = new System.Drawing.Size(43, 21);
            this.txtGrotteCount.TabIndex = 15;
            this.txtGrotteCount.Text = "0";
            // 
            // comboGrotte
            // 
            this.comboGrotte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrotte.Enabled = false;
            this.comboGrotte.FormattingEnabled = true;
            this.comboGrotte.Location = new System.Drawing.Point(8, 17);
            this.comboGrotte.Name = "comboGrotte";
            this.comboGrotte.Size = new System.Drawing.Size(167, 21);
            this.comboGrotte.TabIndex = 10;
            // 
            // checkGrotte
            // 
            this.checkGrotte.AutoSize = true;
            this.checkGrotte.Enabled = false;
            this.checkGrotte.Location = new System.Drawing.Point(48, 0);
            this.checkGrotte.Name = "checkGrotte";
            this.checkGrotte.Size = new System.Drawing.Size(15, 14);
            this.checkGrotte.TabIndex = 14;
            this.checkGrotte.UseVisualStyleBackColor = true;
            this.checkGrotte.CheckedChanged += new System.EventHandler(this.checkGrotte_CheckedChanged);
            // 
            // groupHumanHunt
            // 
            this.groupHumanHunt.Controls.Add(this.lblHumanHuntCount);
            this.groupHumanHunt.Controls.Add(this.txtHumanHuntCount);
            this.groupHumanHunt.Controls.Add(this.comboHumanHunt);
            this.groupHumanHunt.Controls.Add(this.checkHumanHunt);
            this.groupHumanHunt.Enabled = false;
            this.groupHumanHunt.Location = new System.Drawing.Point(6, 127);
            this.groupHumanHunt.Name = "groupHumanHunt";
            this.groupHumanHunt.Size = new System.Drawing.Size(255, 45);
            this.groupHumanHunt.TabIndex = 16;
            this.groupHumanHunt.TabStop = false;
            this.groupHumanHunt.Text = "Human Hunt";
            // 
            // lblHumanHuntCount
            // 
            this.lblHumanHuntCount.AutoSize = true;
            this.lblHumanHuntCount.Location = new System.Drawing.Point(178, 0);
            this.lblHumanHuntCount.Name = "lblHumanHuntCount";
            this.lblHumanHuntCount.Size = new System.Drawing.Size(35, 13);
            this.lblHumanHuntCount.TabIndex = 10;
            this.lblHumanHuntCount.Text = "Count";
            // 
            // txtHumanHuntCount
            // 
            this.txtHumanHuntCount.Location = new System.Drawing.Point(181, 17);
            this.txtHumanHuntCount.MaxLength = 3;
            this.txtHumanHuntCount.Multiline = true;
            this.txtHumanHuntCount.Name = "txtHumanHuntCount";
            this.txtHumanHuntCount.Size = new System.Drawing.Size(43, 21);
            this.txtHumanHuntCount.TabIndex = 15;
            this.txtHumanHuntCount.Text = "0";
            // 
            // comboHumanHunt
            // 
            this.comboHumanHunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHumanHunt.FormattingEnabled = true;
            this.comboHumanHunt.Items.AddRange(new object[] {
            "Farm (1 AP)",
            "Village (1 AP)",
            "Small Town (2 AP)",
            "City (2 AP)",
            "Metropolis (3 AP)"});
            this.comboHumanHunt.Location = new System.Drawing.Point(8, 17);
            this.comboHumanHunt.Name = "comboHumanHunt";
            this.comboHumanHunt.Size = new System.Drawing.Size(167, 21);
            this.comboHumanHunt.TabIndex = 10;
            // 
            // checkHumanHunt
            // 
            this.checkHumanHunt.AutoSize = true;
            this.checkHumanHunt.Location = new System.Drawing.Point(73, 0);
            this.checkHumanHunt.Name = "checkHumanHunt";
            this.checkHumanHunt.Size = new System.Drawing.Size(15, 14);
            this.checkHumanHunt.TabIndex = 14;
            this.checkHumanHunt.UseVisualStyleBackColor = true;
            this.checkHumanHunt.CheckedChanged += new System.EventHandler(this.checkHumanHunt_CheckedChanged);
            // 
            // checkPlayerVsPlayer
            // 
            this.checkPlayerVsPlayer.AutoSize = true;
            this.checkPlayerVsPlayer.Enabled = false;
            this.checkPlayerVsPlayer.Location = new System.Drawing.Point(159, 19);
            this.checkPlayerVsPlayer.Name = "checkPlayerVsPlayer";
            this.checkPlayerVsPlayer.Size = new System.Drawing.Size(102, 17);
            this.checkPlayerVsPlayer.TabIndex = 13;
            this.checkPlayerVsPlayer.Text = "Player Vs Player";
            this.checkPlayerVsPlayer.UseVisualStyleBackColor = true;
            this.checkPlayerVsPlayer.CheckedChanged += new System.EventHandler(this.checkPlayerVsPlayer_CheckedChanged);
            // 
            // lblAPLimit
            // 
            this.lblAPLimit.AutoSize = true;
            this.lblAPLimit.Location = new System.Drawing.Point(112, 20);
            this.lblAPLimit.Name = "lblAPLimit";
            this.lblAPLimit.Size = new System.Drawing.Size(41, 13);
            this.lblAPLimit.TabIndex = 12;
            this.lblAPLimit.Text = "AP limit";
            // 
            // txtAPLimit
            // 
            this.txtAPLimit.Enabled = false;
            this.txtAPLimit.Location = new System.Drawing.Point(79, 16);
            this.txtAPLimit.MaxLength = 3;
            this.txtAPLimit.Name = "txtAPLimit";
            this.txtAPLimit.Size = new System.Drawing.Size(27, 20);
            this.txtAPLimit.TabIndex = 11;
            this.txtAPLimit.Text = "-1";
            // 
            // checkAutoStat
            // 
            this.checkAutoStat.AutoSize = true;
            this.checkAutoStat.Enabled = false;
            this.checkAutoStat.Location = new System.Drawing.Point(159, 43);
            this.checkAutoStat.Name = "checkAutoStat";
            this.checkAutoStat.Size = new System.Drawing.Size(70, 17);
            this.checkAutoStat.TabIndex = 9;
            this.checkAutoStat.Text = "Auto Stat";
            this.checkAutoStat.UseVisualStyleBackColor = true;
            // 
            // checkStory
            // 
            this.checkStory.AutoSize = true;
            this.checkStory.Checked = true;
            this.checkStory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStory.Enabled = false;
            this.checkStory.Location = new System.Drawing.Point(6, 19);
            this.checkStory.Name = "checkStory";
            this.checkStory.Size = new System.Drawing.Size(50, 17);
            this.checkStory.TabIndex = 8;
            this.checkStory.Text = "Story";
            this.checkStory.UseVisualStyleBackColor = true;
            this.checkStory.CheckedChanged += new System.EventHandler(this.checkStory_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(68, 307);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 20);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerAccountInfo
            // 
            this.timerAccountInfo.Interval = 5000;
            this.timerAccountInfo.Tick += new System.EventHandler(this.timerAccountInfo_Tick);
            // 
            // groupLogs
            // 
            this.groupLogs.Controls.Add(this.pictureBox1);
            this.groupLogs.Controls.Add(this.listLogs);
            this.groupLogs.Location = new System.Drawing.Point(12, 333);
            this.groupLogs.Name = "groupLogs";
            this.groupLogs.Size = new System.Drawing.Size(444, 180);
            this.groupLogs.TabIndex = 5;
            this.groupLogs.TabStop = false;
            this.groupLogs.Text = "Logs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BitefightProject.Properties.Resources.moon_blessing;
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // listLogs
            // 
            this.listLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAction});
            this.listLogs.FullRowSelect = true;
            this.listLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listLogs.Location = new System.Drawing.Point(116, 19);
            this.listLogs.MultiSelect = false;
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(316, 155);
            this.listLogs.TabIndex = 6;
            this.listLogs.UseCompatibleStateImageBehavior = false;
            this.listLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnAction
            // 
            this.columnAction.Text = "Action";
            this.columnAction.Width = 320;
            // 
            // EmulatorLogin
            // 
            this.EmulatorLogin.Location = new System.Drawing.Point(617, 54);
            this.EmulatorLogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorLogin.Name = "EmulatorLogin";
            this.EmulatorLogin.Size = new System.Drawing.Size(51, 44);
            this.EmulatorLogin.TabIndex = 6;
            this.EmulatorLogin.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorLogin_DocumentCompleted);
            // 
            // timerLogin
            // 
            this.timerLogin.Interval = 5000;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // EmulatorGoldAPFeature
            // 
            this.EmulatorGoldAPFeature.Location = new System.Drawing.Point(511, 12);
            this.EmulatorGoldAPFeature.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorGoldAPFeature.Name = "EmulatorGoldAPFeature";
            this.EmulatorGoldAPFeature.Size = new System.Drawing.Size(47, 40);
            this.EmulatorGoldAPFeature.TabIndex = 7;
            this.EmulatorGoldAPFeature.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorGoldAPFeature_DocumentCompleted);
            // 
            // EmulatorUsingStat
            // 
            this.EmulatorUsingStat.Location = new System.Drawing.Point(564, 12);
            this.EmulatorUsingStat.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorUsingStat.Name = "EmulatorUsingStat";
            this.EmulatorUsingStat.Size = new System.Drawing.Size(47, 40);
            this.EmulatorUsingStat.TabIndex = 8;
            this.EmulatorUsingStat.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorUsingStat_DocumentCompleted);
            // 
            // EmulatorPlayerVsPlayer
            // 
            this.EmulatorPlayerVsPlayer.Location = new System.Drawing.Point(617, 13);
            this.EmulatorPlayerVsPlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorPlayerVsPlayer.Name = "EmulatorPlayerVsPlayer";
            this.EmulatorPlayerVsPlayer.Size = new System.Drawing.Size(51, 39);
            this.EmulatorPlayerVsPlayer.TabIndex = 9;
            this.EmulatorPlayerVsPlayer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorPlayerVsPlayer_DocumentCompleted);
            // 
            // EmulatorHumanHunt
            // 
            this.EmulatorHumanHunt.Location = new System.Drawing.Point(564, 58);
            this.EmulatorHumanHunt.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorHumanHunt.Name = "EmulatorHumanHunt";
            this.EmulatorHumanHunt.Size = new System.Drawing.Size(47, 40);
            this.EmulatorHumanHunt.TabIndex = 10;
            this.EmulatorHumanHunt.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorHumanHunt_DocumentCompleted);
            // 
            // EmulatorGrotte
            // 
            this.EmulatorGrotte.Location = new System.Drawing.Point(511, 104);
            this.EmulatorGrotte.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorGrotte.Name = "EmulatorGrotte";
            this.EmulatorGrotte.Size = new System.Drawing.Size(47, 44);
            this.EmulatorGrotte.TabIndex = 11;
            this.EmulatorGrotte.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorGrotte_DocumentCompleted);
            // 
            // EmulatorGraveyard
            // 
            this.EmulatorGraveyard.Location = new System.Drawing.Point(564, 104);
            this.EmulatorGraveyard.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorGraveyard.Name = "EmulatorGraveyard";
            this.EmulatorGraveyard.Size = new System.Drawing.Size(47, 44);
            this.EmulatorGraveyard.TabIndex = 12;
            this.EmulatorGraveyard.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorGraveyard_DocumentCompleted);
            // 
            // timerGraveyardWait
            // 
            this.timerGraveyardWait.Tick += new System.EventHandler(this.timerGraveyardWait_Tick);
            // 
            // EmulatorCure
            // 
            this.EmulatorCure.Location = new System.Drawing.Point(617, 104);
            this.EmulatorCure.MinimumSize = new System.Drawing.Size(20, 20);
            this.EmulatorCure.Name = "EmulatorCure";
            this.EmulatorCure.Size = new System.Drawing.Size(51, 44);
            this.EmulatorCure.TabIndex = 13;
            this.EmulatorCure.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.EmulatorCure_DocumentCompleted);
            // 
            // timerAutoCure
            // 
            this.timerAutoCure.Interval = 2000;
            this.timerAutoCure.Tick += new System.EventHandler(this.timerAutoCure_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 523);
            this.Controls.Add(this.EmulatorCure);
            this.Controls.Add(this.EmulatorGraveyard);
            this.Controls.Add(this.EmulatorGrotte);
            this.Controls.Add(this.EmulatorHumanHunt);
            this.Controls.Add(this.EmulatorPlayerVsPlayer);
            this.Controls.Add(this.EmulatorUsingStat);
            this.Controls.Add(this.EmulatorGoldAPFeature);
            this.Controls.Add(this.EmulatorLogin);
            this.Controls.Add(this.groupLogs);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupPlay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupAccountInfo);
            this.Controls.Add(this.Emulator);
            this.Controls.Add(this.groupAccountSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiteFight Bot";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupAccountSettings.ResumeLayout(false);
            this.groupAccountSettings.PerformLayout();
            this.groupAccountInfo.ResumeLayout(false);
            this.groupAccountInfo.PerformLayout();
            this.groupPlay.ResumeLayout(false);
            this.groupPlay.PerformLayout();
            this.groupGraveyard.ResumeLayout(false);
            this.groupGraveyard.PerformLayout();
            this.groupGrotte.ResumeLayout(false);
            this.groupGrotte.PerformLayout();
            this.groupHumanHunt.ResumeLayout(false);
            this.groupHumanHunt.PerformLayout();
            this.groupLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAccountSettings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox comboServers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.WebBrowser Emulator;
        private System.Windows.Forms.GroupBox groupAccountInfo;
        private System.Windows.Forms.GroupBox groupPlay;
        private System.Windows.Forms.Label lblRes3;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblFightValue;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblHerz;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblResSplinters;
        private System.Windows.Forms.Timer timerAccountInfo;
        private System.Windows.Forms.GroupBox groupLogs;
        private System.Windows.Forms.ListView listLogs;
        private System.Windows.Forms.ColumnHeader columnAction;
        private System.Windows.Forms.WebBrowser EmulatorLogin;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.WebBrowser EmulatorGoldAPFeature;
        private System.Windows.Forms.Label lblEnduranceCost;
        private System.Windows.Forms.Label lblDexterityCost;
        private System.Windows.Forms.Label lblDefenceCost;
        private System.Windows.Forms.Label lblForceCost;
        private System.Windows.Forms.Label lblCharismaCost;
        private System.Windows.Forms.CheckBox checkStory;
        private System.Windows.Forms.CheckBox checkAutoStat;
        private System.Windows.Forms.WebBrowser EmulatorUsingStat;
        private System.Windows.Forms.Label lblAPLimit;
        private System.Windows.Forms.TextBox txtAPLimit;
        private System.Windows.Forms.CheckBox checkPlayerVsPlayer;
        private System.Windows.Forms.WebBrowser EmulatorPlayerVsPlayer;
        private System.Windows.Forms.TextBox txtHumanHuntCount;
        private System.Windows.Forms.Label lblHumanHuntCount;
        private System.Windows.Forms.CheckBox checkHumanHunt;
        private System.Windows.Forms.ComboBox comboHumanHunt;
        private System.Windows.Forms.GroupBox groupHumanHunt;
        private System.Windows.Forms.WebBrowser EmulatorHumanHunt;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.WebBrowser EmulatorGrotte;
        private System.Windows.Forms.GroupBox groupGrotte;
        private System.Windows.Forms.Label lblGrotteCount;
        private System.Windows.Forms.TextBox txtGrotteCount;
        private System.Windows.Forms.ComboBox comboGrotte;
        private System.Windows.Forms.CheckBox checkGrotte;
        private System.Windows.Forms.GroupBox groupGraveyard;
        private System.Windows.Forms.Label lblGraveyardCount;
        private System.Windows.Forms.TextBox txtGraveyardCount;
        private System.Windows.Forms.ComboBox comboGraveyard;
        private System.Windows.Forms.CheckBox checkGraveyard;
        private System.Windows.Forms.WebBrowser EmulatorGraveyard;
        private System.Windows.Forms.Timer timerGraveyardWait;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser EmulatorCure;
        private System.Windows.Forms.CheckBox checkAutoCure;
        private System.Windows.Forms.Label lblAPLimit2;
        private System.Windows.Forms.TextBox txtAPLimit2;
        private System.Windows.Forms.Timer timerAutoCure;
    }
}

