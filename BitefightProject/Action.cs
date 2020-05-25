using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitefightProject
{
    public partial class Action : Form
    {
        public static dynamic Settings = new IniFile("Settings.ini");
        public Main frmMain = (Main)Application.OpenForms["Main"];
        public Action()
        {
            InitializeComponent();
            if (frmMain.SelectedServer.Length > 0)
            {
                GetData(frmMain.SelectedServer);
                btnAdd.Text = "Edit";
            }
            else
            {
                btnAdd.Text = "Add";
            }
        }

        public bool ControlExists(string Server)
        {
            for (int i = 0; i < FormTools.GetAccountCount(); i++)
            {
                if (Server == frmMain.SelectedServer)
                {
                    return false;
                }
                else if (Settings.Read("Server", "Account" + i).ToString() == Server)
                {
                    return true;
                }
            }
            return false;
        }

        private void GetData(string Server)
        {
            try
            {
                int AccountID = FormTools.GetAccountID(Server);
                txtServer.Text = Settings.Read("Server", "Account" + AccountID);
                txtBrowser.Text = Settings.Read("Browser", "Account" + AccountID);
                txtCookie.Text = Settings.Read("Cookie", "Account" + AccountID);
                txtStoryDelay.Text = Settings.Read("StoryDelay", "Account" + AccountID);
                txtStoryMinLife.Text = Settings.Read("StoryMinLife", "Account" + AccountID);
                txtStoryPriorities.Text = Settings.Read("StoryPriorities", "Account" + AccountID);
                txtStoryBlackList.Text = Settings.Read("StoryBlackList", "Account" + AccountID);

                txtPvPDelay.Text = Settings.Read("PvPDelay", "Account" + AccountID);
                txtPvPMinLife.Text = Settings.Read("PvPMinLife", "Account" + AccountID);

                string[] AutoStats = Settings.Read("AutoStats", "Account" + AccountID).Split(' ');
                for (int i = 0; i < AutoStats.Length; i++)
                {
                    listASStats.Items.Add(AutoStats[i]);
                }

                string[] PvPWhitelist = Settings.Read("PvPWhitelist", "Account" + AccountID).Split(' ');
                for (int i = 0; i < PvPWhitelist.Length; i++)
                {
                    listPvPWhitelist.Items.Add(PvPWhitelist[i]);
                }

                string[] PvPBlacklist = Settings.Read("PvPBlacklist", "Account" + AccountID).Split(' ');
                for (int i = 0; i < PvPBlacklist.Length; i++)
                {
                    listPvPBlacklist.Items.Add(PvPBlacklist[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ini file is incorrect : " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (!ControlExists(txtServer.Text))
                {
                    int AccountID = FormTools.GetUniqueID();
                    Settings.Write("Server", txtServer.Text, "Account" + AccountID);
                    Settings.Write("Browser", txtBrowser.Text, "Account" + AccountID);
                    Settings.Write("Cookie", txtCookie.Text, "Account" + AccountID);
                    Settings.Write("StoryDelay", txtStoryDelay.Text, "Account" + AccountID);
                    Settings.Write("StoryMinLife", txtStoryMinLife.Text, "Account" + AccountID);
                    Settings.Write("StoryPriorities", txtStoryPriorities.Text, "Account" + AccountID);
                    Settings.Write("StoryBlackList", txtStoryBlackList.Text, "Account" + AccountID);

                    Settings.Write("PvPDelay", txtPvPDelay.Text, "Account" + AccountID);
                    Settings.Write("PvPMinLife", txtPvPMinLife.Text, "Account" + AccountID);

                    string templistPvPWhitelist = "";
                    for (int i = 0; i < listPvPWhitelist.Items.Count; i++)
                    {
                        templistPvPWhitelist += listPvPWhitelist.Items[i].Text + " ";
                    }
                    Settings.Write("PvPWhitelist", (templistPvPWhitelist.Length > 0 ? templistPvPWhitelist.Substring(0, templistPvPWhitelist.Length - 1) : ""), "Account" + AccountID);

                    string templistPvPBlacklist = "";
                    for (int i = 0; i < listPvPBlacklist.Items.Count; i++)
                    {
                        templistPvPBlacklist += listPvPBlacklist.Items[i].Text + " ";
                    }
                    Settings.Write("PvPBlacklist", (templistPvPBlacklist.Length > 0 ? templistPvPBlacklist.Substring(0, templistPvPBlacklist.Length - 1) : ""), "Account" + AccountID);


                    string templistASStats = "";
                    for (int i = 0; i < listASStats.Items.Count; i++)
                    {
                        templistASStats += listASStats.Items[i].Text + " ";
                    }
                    Settings.Write("AutoStats", (templistASStats.Length > 0 ? templistASStats.Substring(0, templistASStats.Length - 1) : ""), "Account" + AccountID);
                    Settings.Write("AutoStatsCounter", "0", "Account" + AccountID);
                }
                else
                {
                    MessageBox.Show("Already exists ");
                    return;
                }
            }
            else if (btnAdd.Text == "Edit")
            {
                if (!ControlExists(txtServer.Text))
                {
                    int AccountID = FormTools.GetAccountID(frmMain.SelectedServer);
                    Settings.DeleteSection("Account" + AccountID);
                    Settings.Write("Server", txtServer.Text, "Account" + AccountID);
                    Settings.Write("Browser", txtBrowser.Text, "Account" + AccountID);
                    Settings.Write("Cookie", txtCookie.Text, "Account" + AccountID);
                    Settings.Write("StoryDelay", txtStoryDelay.Text, "Account" + AccountID);
                    Settings.Write("StoryMinLife", txtStoryMinLife.Text, "Account" + AccountID);
                    Settings.Write("StoryPriorities", txtStoryPriorities.Text, "Account" + AccountID);
                    Settings.Write("StoryBlackList", txtStoryBlackList.Text, "Account" + AccountID);

                    Settings.Write("PvPDelay", txtPvPDelay.Text, "Account" + AccountID);
                    Settings.Write("PvPMinLife", txtPvPMinLife.Text, "Account" + AccountID);

                    string templistPvPWhitelist = "";
                    for (int i = 0; i < listPvPWhitelist.Items.Count; i++)
                    {
                        templistPvPWhitelist += listPvPWhitelist.Items[i].Text + " ";
                    }
                    Settings.Write("PvPWhitelist", (templistPvPWhitelist.Length > 0 ? templistPvPWhitelist.Substring(0, templistPvPWhitelist.Length - 1) : ""), "Account" + AccountID);

                    string templistPvPBlacklist = "";
                    for (int i = 0; i < listPvPBlacklist.Items.Count; i++)
                    {
                        templistPvPBlacklist += listPvPBlacklist.Items[i].Text + " ";
                    }
                    Settings.Write("PvPBlacklist", (templistPvPBlacklist.Length > 0 ? templistPvPBlacklist.Substring(0, templistPvPBlacklist.Length - 1) : ""), "Account" + AccountID);


                    string templistASStats = "";
                    for (int i = 0; i < listASStats.Items.Count; i++)
                    {
                        templistASStats += listASStats.Items[i].Text + " ";
                    }
                    Settings.Write("AutoStats", (templistASStats.Length > 0 ? templistASStats.Substring(0, templistASStats.Length - 1) : ""), "Account" + AccountID);
                    Settings.Write("AutoStatsCounter", "0", "Account" + AccountID);
                }
                else
                {
                    MessageBox.Show("Already exists ");
                    return;
                }
            }
            frmMain.LoadAccounts();
            this.Close();
        }

        private void btnASAddStat_Click(object sender, EventArgs e)
        {
            if (comboASStats.SelectedIndex != -1)
            {
                for (int i = 0; i < listASStats.Items.Count; i++)
                {
                    if (comboASStats.SelectedItem.ToString() == listASStats.Items[i].Text)
                    {
                        MessageBox.Show("Already added.");
                        return;
                    }
                }
                listASStats.Items.Add(comboASStats.SelectedItem.ToString());
            }
        }

        private void btnASDelStat_Click(object sender, EventArgs e)
        {
            if (listASStats.SelectedIndices.Count > 0)
            {
                listASStats.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Please choose.");
                return;
            }
        }

        private void checkPvPInsertBlacklist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPvPInsertBlacklist.Checked)
            {
                checkPvPInsertWhitelist.Checked = false;
            }
        }

        private void checkPvPInsertWhitelist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPvPInsertWhitelist.Checked)
            {
                checkPvPInsertBlacklist.Checked = false;
            }
        }

        private void btnPvPAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPvPBlacklist.Items.Count; i++)
            {
                if (listPvPBlacklist.Items[i].Text.IndexOf(txtPvPPlayer.Text) != -1)
                {
                    return;
                }
            }
            for (int i = 0; i < listPvPWhitelist.Items.Count; i++)
            {
                if (listPvPWhitelist.Items[i].Text.IndexOf(txtPvPPlayer.Text) != -1)
                {
                    return;
                }
            }
            if (checkPvPInsertBlacklist.Checked)
            {
                listPvPBlacklist.Items.Add(txtPvPPlayer.Text + "(" + txtPvPServer.Text + ")");
            }
            else if (checkPvPInsertWhitelist.Checked)
            {
                listPvPWhitelist.Items.Add(txtPvPPlayer.Text + "(" + txtPvPServer.Text + ")");
            }

        }

        private void btnPvPDelete_Click(object sender, EventArgs e)
        {
            if (checkPvPInsertBlacklist.Checked)
            {
                if (listPvPBlacklist.SelectedIndices.Count > 0)
                {
                    listPvPBlacklist.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Please choose.");
                    return;
                }
            }
            else if (checkPvPInsertWhitelist.Checked)
            {
                if (listPvPWhitelist.SelectedIndices.Count > 0)
                {
                    listPvPWhitelist.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Please choose.");
                    return;
                }
            }
        }
    }
}
