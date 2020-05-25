namespace BitefightProject
{
    partial class Action
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
            this.lblServer = new System.Windows.Forms.Label();
            this.lblBrowser = new System.Windows.Forms.Label();
            this.lblCookie = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtBrowser = new System.Windows.Forms.TextBox();
            this.txtCookie = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStory = new System.Windows.Forms.TabPage();
            this.lblPvPBlackList = new System.Windows.Forms.Label();
            this.txtStoryBlackList = new System.Windows.Forms.TextBox();
            this.lblPvPPriorities = new System.Windows.Forms.Label();
            this.txtStoryPriorities = new System.Windows.Forms.TextBox();
            this.lblStoryMinLife = new System.Windows.Forms.Label();
            this.txtStoryMinLife = new System.Windows.Forms.TextBox();
            this.lblStoryDelay = new System.Windows.Forms.Label();
            this.txtStoryDelay = new System.Windows.Forms.TextBox();
            this.tabPlayerVsPlayer = new System.Windows.Forms.TabPage();
            this.groupPvPInsert = new System.Windows.Forms.GroupBox();
            this.checkPvPInsertWhitelist = new System.Windows.Forms.CheckBox();
            this.checkPvPInsertBlacklist = new System.Windows.Forms.CheckBox();
            this.btnPvPDelete = new System.Windows.Forms.Button();
            this.btnPvPAdd = new System.Windows.Forms.Button();
            this.txtPvPServer = new System.Windows.Forms.TextBox();
            this.lblPvPServer = new System.Windows.Forms.Label();
            this.txtPvPPlayer = new System.Windows.Forms.TextBox();
            this.lblPvPPlayer = new System.Windows.Forms.Label();
            this.groupPvPBlacklist = new System.Windows.Forms.GroupBox();
            this.listPvPBlacklist = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPvPWhitelist = new System.Windows.Forms.GroupBox();
            this.listPvPWhitelist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkPvPBlacklist = new System.Windows.Forms.CheckBox();
            this.checkPvPRandom = new System.Windows.Forms.CheckBox();
            this.txtPvPMinLife = new System.Windows.Forms.TextBox();
            this.lblPvPMinLife = new System.Windows.Forms.Label();
            this.txtPvPDelay = new System.Windows.Forms.TextBox();
            this.lblPvPDelay = new System.Windows.Forms.Label();
            this.tabAutoStat = new System.Windows.Forms.TabPage();
            this.lbASWait = new System.Windows.Forms.Label();
            this.txtASWait = new System.Windows.Forms.TextBox();
            this.btnASDelStat = new System.Windows.Forms.Button();
            this.btnASAddStat = new System.Windows.Forms.Button();
            this.comboASStats = new System.Windows.Forms.ComboBox();
            this.listASStats = new System.Windows.Forms.ListView();
            this.columnStatsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabStory.SuspendLayout();
            this.tabPlayerVsPlayer.SuspendLayout();
            this.groupPvPInsert.SuspendLayout();
            this.groupPvPBlacklist.SuspendLayout();
            this.groupPvPWhitelist.SuspendLayout();
            this.tabAutoStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // lblBrowser
            // 
            this.lblBrowser.AutoSize = true;
            this.lblBrowser.Location = new System.Drawing.Point(12, 41);
            this.lblBrowser.Name = "lblBrowser";
            this.lblBrowser.Size = new System.Drawing.Size(45, 13);
            this.lblBrowser.TabIndex = 1;
            this.lblBrowser.Text = "Browser";
            // 
            // lblCookie
            // 
            this.lblCookie.AutoSize = true;
            this.lblCookie.Location = new System.Drawing.Point(12, 67);
            this.lblCookie.Name = "lblCookie";
            this.lblCookie.Size = new System.Drawing.Size(40, 13);
            this.lblCookie.TabIndex = 2;
            this.lblCookie.Text = "Cookie";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(60, 12);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(416, 20);
            this.txtServer.TabIndex = 3;
            // 
            // txtBrowser
            // 
            this.txtBrowser.Location = new System.Drawing.Point(60, 38);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Size = new System.Drawing.Size(416, 20);
            this.txtBrowser.TabIndex = 4;
            // 
            // txtCookie
            // 
            this.txtCookie.Location = new System.Drawing.Point(60, 64);
            this.txtCookie.Name = "txtCookie";
            this.txtCookie.Size = new System.Drawing.Size(416, 20);
            this.txtCookie.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStory);
            this.tabControl1.Controls.Add(this.tabPlayerVsPlayer);
            this.tabControl1.Controls.Add(this.tabAutoStat);
            this.tabControl1.Location = new System.Drawing.Point(15, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 327);
            this.tabControl1.TabIndex = 6;
            // 
            // tabStory
            // 
            this.tabStory.Controls.Add(this.lblPvPBlackList);
            this.tabStory.Controls.Add(this.txtStoryBlackList);
            this.tabStory.Controls.Add(this.lblPvPPriorities);
            this.tabStory.Controls.Add(this.txtStoryPriorities);
            this.tabStory.Controls.Add(this.lblStoryMinLife);
            this.tabStory.Controls.Add(this.txtStoryMinLife);
            this.tabStory.Controls.Add(this.lblStoryDelay);
            this.tabStory.Controls.Add(this.txtStoryDelay);
            this.tabStory.Location = new System.Drawing.Point(4, 22);
            this.tabStory.Name = "tabStory";
            this.tabStory.Padding = new System.Windows.Forms.Padding(3);
            this.tabStory.Size = new System.Drawing.Size(453, 301);
            this.tabStory.TabIndex = 0;
            this.tabStory.Text = "Story";
            this.tabStory.UseVisualStyleBackColor = true;
            // 
            // lblPvPBlackList
            // 
            this.lblPvPBlackList.AutoSize = true;
            this.lblPvPBlackList.Location = new System.Drawing.Point(6, 87);
            this.lblPvPBlackList.Name = "lblPvPBlackList";
            this.lblPvPBlackList.Size = new System.Drawing.Size(46, 13);
            this.lblPvPBlackList.TabIndex = 7;
            this.lblPvPBlackList.Text = "Blacklist";
            // 
            // txtStoryBlackList
            // 
            this.txtStoryBlackList.Location = new System.Drawing.Point(64, 84);
            this.txtStoryBlackList.Name = "txtStoryBlackList";
            this.txtStoryBlackList.Size = new System.Drawing.Size(383, 20);
            this.txtStoryBlackList.TabIndex = 6;
            // 
            // lblPvPPriorities
            // 
            this.lblPvPPriorities.AutoSize = true;
            this.lblPvPPriorities.Location = new System.Drawing.Point(4, 61);
            this.lblPvPPriorities.Name = "lblPvPPriorities";
            this.lblPvPPriorities.Size = new System.Drawing.Size(46, 13);
            this.lblPvPPriorities.TabIndex = 5;
            this.lblPvPPriorities.Text = "Priorities";
            // 
            // txtStoryPriorities
            // 
            this.txtStoryPriorities.Location = new System.Drawing.Point(64, 58);
            this.txtStoryPriorities.Name = "txtStoryPriorities";
            this.txtStoryPriorities.Size = new System.Drawing.Size(383, 20);
            this.txtStoryPriorities.TabIndex = 4;
            // 
            // lblStoryMinLife
            // 
            this.lblStoryMinLife.AutoSize = true;
            this.lblStoryMinLife.Location = new System.Drawing.Point(3, 35);
            this.lblStoryMinLife.Name = "lblStoryMinLife";
            this.lblStoryMinLife.Size = new System.Drawing.Size(47, 13);
            this.lblStoryMinLife.TabIndex = 3;
            this.lblStoryMinLife.Text = "Min. Life";
            // 
            // txtStoryMinLife
            // 
            this.txtStoryMinLife.Location = new System.Drawing.Point(64, 32);
            this.txtStoryMinLife.Name = "txtStoryMinLife";
            this.txtStoryMinLife.Size = new System.Drawing.Size(383, 20);
            this.txtStoryMinLife.TabIndex = 2;
            this.txtStoryMinLife.Text = "5000";
            // 
            // lblStoryDelay
            // 
            this.lblStoryDelay.AutoSize = true;
            this.lblStoryDelay.Location = new System.Drawing.Point(2, 9);
            this.lblStoryDelay.Name = "lblStoryDelay";
            this.lblStoryDelay.Size = new System.Drawing.Size(34, 13);
            this.lblStoryDelay.TabIndex = 1;
            this.lblStoryDelay.Text = "Delay";
            // 
            // txtStoryDelay
            // 
            this.txtStoryDelay.Location = new System.Drawing.Point(64, 6);
            this.txtStoryDelay.Name = "txtStoryDelay";
            this.txtStoryDelay.Size = new System.Drawing.Size(383, 20);
            this.txtStoryDelay.TabIndex = 0;
            this.txtStoryDelay.Text = "100";
            // 
            // tabPlayerVsPlayer
            // 
            this.tabPlayerVsPlayer.Controls.Add(this.groupPvPInsert);
            this.tabPlayerVsPlayer.Controls.Add(this.groupPvPBlacklist);
            this.tabPlayerVsPlayer.Controls.Add(this.groupPvPWhitelist);
            this.tabPlayerVsPlayer.Controls.Add(this.checkPvPBlacklist);
            this.tabPlayerVsPlayer.Controls.Add(this.checkPvPRandom);
            this.tabPlayerVsPlayer.Controls.Add(this.txtPvPMinLife);
            this.tabPlayerVsPlayer.Controls.Add(this.lblPvPMinLife);
            this.tabPlayerVsPlayer.Controls.Add(this.txtPvPDelay);
            this.tabPlayerVsPlayer.Controls.Add(this.lblPvPDelay);
            this.tabPlayerVsPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPlayerVsPlayer.Name = "tabPlayerVsPlayer";
            this.tabPlayerVsPlayer.Size = new System.Drawing.Size(453, 301);
            this.tabPlayerVsPlayer.TabIndex = 2;
            this.tabPlayerVsPlayer.Text = "Player Vs Player";
            this.tabPlayerVsPlayer.UseVisualStyleBackColor = true;
            // 
            // groupPvPInsert
            // 
            this.groupPvPInsert.Controls.Add(this.checkPvPInsertWhitelist);
            this.groupPvPInsert.Controls.Add(this.checkPvPInsertBlacklist);
            this.groupPvPInsert.Controls.Add(this.btnPvPDelete);
            this.groupPvPInsert.Controls.Add(this.btnPvPAdd);
            this.groupPvPInsert.Controls.Add(this.txtPvPServer);
            this.groupPvPInsert.Controls.Add(this.lblPvPServer);
            this.groupPvPInsert.Controls.Add(this.txtPvPPlayer);
            this.groupPvPInsert.Controls.Add(this.lblPvPPlayer);
            this.groupPvPInsert.Location = new System.Drawing.Point(16, 204);
            this.groupPvPInsert.Name = "groupPvPInsert";
            this.groupPvPInsert.Size = new System.Drawing.Size(420, 84);
            this.groupPvPInsert.TabIndex = 12;
            this.groupPvPInsert.TabStop = false;
            this.groupPvPInsert.Text = "Insert";
            // 
            // checkPvPInsertWhitelist
            // 
            this.checkPvPInsertWhitelist.AutoSize = true;
            this.checkPvPInsertWhitelist.Enabled = false;
            this.checkPvPInsertWhitelist.Location = new System.Drawing.Point(227, 50);
            this.checkPvPInsertWhitelist.Name = "checkPvPInsertWhitelist";
            this.checkPvPInsertWhitelist.Size = new System.Drawing.Size(66, 17);
            this.checkPvPInsertWhitelist.TabIndex = 11;
            this.checkPvPInsertWhitelist.Text = "Whitelist";
            this.checkPvPInsertWhitelist.UseVisualStyleBackColor = true;
            this.checkPvPInsertWhitelist.CheckedChanged += new System.EventHandler(this.checkPvPInsertWhitelist_CheckedChanged);
            // 
            // checkPvPInsertBlacklist
            // 
            this.checkPvPInsertBlacklist.AutoSize = true;
            this.checkPvPInsertBlacklist.Checked = true;
            this.checkPvPInsertBlacklist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPvPInsertBlacklist.Location = new System.Drawing.Point(227, 27);
            this.checkPvPInsertBlacklist.Name = "checkPvPInsertBlacklist";
            this.checkPvPInsertBlacklist.Size = new System.Drawing.Size(65, 17);
            this.checkPvPInsertBlacklist.TabIndex = 10;
            this.checkPvPInsertBlacklist.Text = "Blacklist";
            this.checkPvPInsertBlacklist.UseVisualStyleBackColor = true;
            this.checkPvPInsertBlacklist.CheckedChanged += new System.EventHandler(this.checkPvPInsertBlacklist_CheckedChanged);
            // 
            // btnPvPDelete
            // 
            this.btnPvPDelete.Location = new System.Drawing.Point(166, 47);
            this.btnPvPDelete.Name = "btnPvPDelete";
            this.btnPvPDelete.Size = new System.Drawing.Size(55, 20);
            this.btnPvPDelete.TabIndex = 9;
            this.btnPvPDelete.Text = "Delete";
            this.btnPvPDelete.UseVisualStyleBackColor = true;
            this.btnPvPDelete.Click += new System.EventHandler(this.btnPvPDelete_Click);
            // 
            // btnPvPAdd
            // 
            this.btnPvPAdd.Location = new System.Drawing.Point(166, 25);
            this.btnPvPAdd.Name = "btnPvPAdd";
            this.btnPvPAdd.Size = new System.Drawing.Size(55, 20);
            this.btnPvPAdd.TabIndex = 8;
            this.btnPvPAdd.Text = "Add";
            this.btnPvPAdd.UseVisualStyleBackColor = true;
            this.btnPvPAdd.Click += new System.EventHandler(this.btnPvPAdd_Click);
            // 
            // txtPvPServer
            // 
            this.txtPvPServer.Location = new System.Drawing.Point(54, 48);
            this.txtPvPServer.Name = "txtPvPServer";
            this.txtPvPServer.Size = new System.Drawing.Size(106, 20);
            this.txtPvPServer.TabIndex = 7;
            // 
            // lblPvPServer
            // 
            this.lblPvPServer.AutoSize = true;
            this.lblPvPServer.Location = new System.Drawing.Point(10, 51);
            this.lblPvPServer.Name = "lblPvPServer";
            this.lblPvPServer.Size = new System.Drawing.Size(38, 13);
            this.lblPvPServer.TabIndex = 6;
            this.lblPvPServer.Text = "Server";
            // 
            // txtPvPPlayer
            // 
            this.txtPvPPlayer.Location = new System.Drawing.Point(54, 22);
            this.txtPvPPlayer.Name = "txtPvPPlayer";
            this.txtPvPPlayer.Size = new System.Drawing.Size(106, 20);
            this.txtPvPPlayer.TabIndex = 5;
            // 
            // lblPvPPlayer
            // 
            this.lblPvPPlayer.AutoSize = true;
            this.lblPvPPlayer.Location = new System.Drawing.Point(10, 25);
            this.lblPvPPlayer.Name = "lblPvPPlayer";
            this.lblPvPPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPvPPlayer.TabIndex = 4;
            this.lblPvPPlayer.Text = "Player";
            // 
            // groupPvPBlacklist
            // 
            this.groupPvPBlacklist.Controls.Add(this.listPvPBlacklist);
            this.groupPvPBlacklist.Location = new System.Drawing.Point(236, 98);
            this.groupPvPBlacklist.Name = "groupPvPBlacklist";
            this.groupPvPBlacklist.Size = new System.Drawing.Size(200, 100);
            this.groupPvPBlacklist.TabIndex = 11;
            this.groupPvPBlacklist.TabStop = false;
            this.groupPvPBlacklist.Text = "Black List";
            // 
            // listPvPBlacklist
            // 
            this.listPvPBlacklist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listPvPBlacklist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listPvPBlacklist.Location = new System.Drawing.Point(6, 19);
            this.listPvPBlacklist.MultiSelect = false;
            this.listPvPBlacklist.Name = "listPvPBlacklist";
            this.listPvPBlacklist.Size = new System.Drawing.Size(188, 75);
            this.listPvPBlacklist.TabIndex = 9;
            this.listPvPBlacklist.UseCompatibleStateImageBehavior = false;
            this.listPvPBlacklist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 110;
            // 
            // groupPvPWhitelist
            // 
            this.groupPvPWhitelist.Controls.Add(this.listPvPWhitelist);
            this.groupPvPWhitelist.Location = new System.Drawing.Point(16, 98);
            this.groupPvPWhitelist.Name = "groupPvPWhitelist";
            this.groupPvPWhitelist.Size = new System.Drawing.Size(200, 100);
            this.groupPvPWhitelist.TabIndex = 10;
            this.groupPvPWhitelist.TabStop = false;
            this.groupPvPWhitelist.Text = "White List";
            // 
            // listPvPWhitelist
            // 
            this.listPvPWhitelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listPvPWhitelist.Enabled = false;
            this.listPvPWhitelist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listPvPWhitelist.Location = new System.Drawing.Point(6, 19);
            this.listPvPWhitelist.MultiSelect = false;
            this.listPvPWhitelist.Name = "listPvPWhitelist";
            this.listPvPWhitelist.Size = new System.Drawing.Size(188, 75);
            this.listPvPWhitelist.TabIndex = 9;
            this.listPvPWhitelist.UseCompatibleStateImageBehavior = false;
            this.listPvPWhitelist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 110;
            // 
            // checkPvPBlacklist
            // 
            this.checkPvPBlacklist.AutoSize = true;
            this.checkPvPBlacklist.Checked = true;
            this.checkPvPBlacklist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPvPBlacklist.Location = new System.Drawing.Point(88, 65);
            this.checkPvPBlacklist.Name = "checkPvPBlacklist";
            this.checkPvPBlacklist.Size = new System.Drawing.Size(65, 17);
            this.checkPvPBlacklist.TabIndex = 5;
            this.checkPvPBlacklist.Text = "Blacklist";
            this.checkPvPBlacklist.UseVisualStyleBackColor = true;
            // 
            // checkPvPRandom
            // 
            this.checkPvPRandom.AutoSize = true;
            this.checkPvPRandom.Checked = true;
            this.checkPvPRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPvPRandom.Enabled = false;
            this.checkPvPRandom.Location = new System.Drawing.Point(16, 65);
            this.checkPvPRandom.Name = "checkPvPRandom";
            this.checkPvPRandom.Size = new System.Drawing.Size(66, 17);
            this.checkPvPRandom.TabIndex = 4;
            this.checkPvPRandom.Text = "Random";
            this.checkPvPRandom.UseVisualStyleBackColor = true;
            // 
            // txtPvPMinLife
            // 
            this.txtPvPMinLife.Location = new System.Drawing.Point(66, 39);
            this.txtPvPMinLife.Name = "txtPvPMinLife";
            this.txtPvPMinLife.Size = new System.Drawing.Size(370, 20);
            this.txtPvPMinLife.TabIndex = 3;
            this.txtPvPMinLife.Text = "5000";
            // 
            // lblPvPMinLife
            // 
            this.lblPvPMinLife.AutoSize = true;
            this.lblPvPMinLife.Location = new System.Drawing.Point(13, 42);
            this.lblPvPMinLife.Name = "lblPvPMinLife";
            this.lblPvPMinLife.Size = new System.Drawing.Size(47, 13);
            this.lblPvPMinLife.TabIndex = 2;
            this.lblPvPMinLife.Text = "Min. Life";
            // 
            // txtPvPDelay
            // 
            this.txtPvPDelay.Location = new System.Drawing.Point(66, 13);
            this.txtPvPDelay.Name = "txtPvPDelay";
            this.txtPvPDelay.Size = new System.Drawing.Size(370, 20);
            this.txtPvPDelay.TabIndex = 1;
            this.txtPvPDelay.Text = "100";
            // 
            // lblPvPDelay
            // 
            this.lblPvPDelay.AutoSize = true;
            this.lblPvPDelay.Location = new System.Drawing.Point(13, 16);
            this.lblPvPDelay.Name = "lblPvPDelay";
            this.lblPvPDelay.Size = new System.Drawing.Size(34, 13);
            this.lblPvPDelay.TabIndex = 0;
            this.lblPvPDelay.Text = "Delay";
            // 
            // tabAutoStat
            // 
            this.tabAutoStat.Controls.Add(this.lbASWait);
            this.tabAutoStat.Controls.Add(this.txtASWait);
            this.tabAutoStat.Controls.Add(this.btnASDelStat);
            this.tabAutoStat.Controls.Add(this.btnASAddStat);
            this.tabAutoStat.Controls.Add(this.comboASStats);
            this.tabAutoStat.Controls.Add(this.listASStats);
            this.tabAutoStat.Location = new System.Drawing.Point(4, 22);
            this.tabAutoStat.Name = "tabAutoStat";
            this.tabAutoStat.Size = new System.Drawing.Size(453, 301);
            this.tabAutoStat.TabIndex = 1;
            this.tabAutoStat.Text = "Auto Stat";
            this.tabAutoStat.UseVisualStyleBackColor = true;
            // 
            // lbASWait
            // 
            this.lbASWait.AutoSize = true;
            this.lbASWait.Location = new System.Drawing.Point(2, 132);
            this.lbASWait.Name = "lbASWait";
            this.lbASWait.Size = new System.Drawing.Size(29, 13);
            this.lbASWait.TabIndex = 13;
            this.lbASWait.Text = "Wait";
            // 
            // txtASWait
            // 
            this.txtASWait.Location = new System.Drawing.Point(37, 129);
            this.txtASWait.Name = "txtASWait";
            this.txtASWait.Size = new System.Drawing.Size(60, 20);
            this.txtASWait.TabIndex = 12;
            this.txtASWait.Text = "100";
            // 
            // btnASDelStat
            // 
            this.btnASDelStat.Location = new System.Drawing.Point(395, 30);
            this.btnASDelStat.Name = "btnASDelStat";
            this.btnASDelStat.Size = new System.Drawing.Size(55, 23);
            this.btnASDelStat.TabIndex = 10;
            this.btnASDelStat.Text = "-";
            this.btnASDelStat.UseVisualStyleBackColor = true;
            this.btnASDelStat.Click += new System.EventHandler(this.btnASDelStat_Click);
            // 
            // btnASAddStat
            // 
            this.btnASAddStat.Location = new System.Drawing.Point(329, 30);
            this.btnASAddStat.Name = "btnASAddStat";
            this.btnASAddStat.Size = new System.Drawing.Size(60, 23);
            this.btnASAddStat.TabIndex = 9;
            this.btnASAddStat.Text = "+";
            this.btnASAddStat.UseVisualStyleBackColor = true;
            this.btnASAddStat.Click += new System.EventHandler(this.btnASAddStat_Click);
            // 
            // comboASStats
            // 
            this.comboASStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboASStats.FormattingEnabled = true;
            this.comboASStats.Items.AddRange(new object[] {
            "Strength",
            "Defense",
            "Dexterity",
            "Endurance",
            "Charisma"});
            this.comboASStats.Location = new System.Drawing.Point(329, 3);
            this.comboASStats.Name = "comboASStats";
            this.comboASStats.Size = new System.Drawing.Size(121, 21);
            this.comboASStats.TabIndex = 8;
            // 
            // listASStats
            // 
            this.listASStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStatsName});
            this.listASStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listASStats.Location = new System.Drawing.Point(3, 3);
            this.listASStats.MultiSelect = false;
            this.listASStats.Name = "listASStats";
            this.listASStats.Size = new System.Drawing.Size(320, 120);
            this.listASStats.TabIndex = 0;
            this.listASStats.UseCompatibleStateImageBehavior = false;
            this.listASStats.View = System.Windows.Forms.View.Details;
            // 
            // columnStatsName
            // 
            this.columnStatsName.Text = "";
            this.columnStatsName.Width = 110;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(401, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 444);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCookie);
            this.Controls.Add(this.txtBrowser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblCookie);
            this.Controls.Add(this.lblBrowser);
            this.Controls.Add(this.lblServer);
            this.MaximizeBox = false;
            this.Name = "Action";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.tabControl1.ResumeLayout(false);
            this.tabStory.ResumeLayout(false);
            this.tabStory.PerformLayout();
            this.tabPlayerVsPlayer.ResumeLayout(false);
            this.tabPlayerVsPlayer.PerformLayout();
            this.groupPvPInsert.ResumeLayout(false);
            this.groupPvPInsert.PerformLayout();
            this.groupPvPBlacklist.ResumeLayout(false);
            this.groupPvPWhitelist.ResumeLayout(false);
            this.tabAutoStat.ResumeLayout(false);
            this.tabAutoStat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblBrowser;
        private System.Windows.Forms.Label lblCookie;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtBrowser;
        private System.Windows.Forms.TextBox txtCookie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStory;
        private System.Windows.Forms.Label lblStoryDelay;
        private System.Windows.Forms.TextBox txtStoryDelay;
        private System.Windows.Forms.Label lblPvPBlackList;
        private System.Windows.Forms.TextBox txtStoryBlackList;
        private System.Windows.Forms.Label lblPvPPriorities;
        private System.Windows.Forms.TextBox txtStoryPriorities;
        private System.Windows.Forms.Label lblStoryMinLife;
        private System.Windows.Forms.TextBox txtStoryMinLife;
        private System.Windows.Forms.TabPage tabAutoStat;
        private System.Windows.Forms.Button btnASDelStat;
        private System.Windows.Forms.Button btnASAddStat;
        private System.Windows.Forms.ComboBox comboASStats;
        private System.Windows.Forms.ColumnHeader columnStatsName;
        private System.Windows.Forms.Label lbASWait;
        private System.Windows.Forms.TextBox txtASWait;
        public System.Windows.Forms.ListView listASStats;
        private System.Windows.Forms.TabPage tabPlayerVsPlayer;
        private System.Windows.Forms.CheckBox checkPvPBlacklist;
        private System.Windows.Forms.CheckBox checkPvPRandom;
        private System.Windows.Forms.TextBox txtPvPMinLife;
        private System.Windows.Forms.Label lblPvPMinLife;
        private System.Windows.Forms.TextBox txtPvPDelay;
        private System.Windows.Forms.Label lblPvPDelay;
        private System.Windows.Forms.GroupBox groupPvPInsert;
        private System.Windows.Forms.TextBox txtPvPServer;
        private System.Windows.Forms.Label lblPvPServer;
        private System.Windows.Forms.TextBox txtPvPPlayer;
        private System.Windows.Forms.Label lblPvPPlayer;
        private System.Windows.Forms.GroupBox groupPvPBlacklist;
        public System.Windows.Forms.ListView listPvPBlacklist;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupPvPWhitelist;
        public System.Windows.Forms.ListView listPvPWhitelist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPvPDelete;
        private System.Windows.Forms.Button btnPvPAdd;
        private System.Windows.Forms.CheckBox checkPvPInsertWhitelist;
        private System.Windows.Forms.CheckBox checkPvPInsertBlacklist;
    }
}