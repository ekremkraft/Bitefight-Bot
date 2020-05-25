using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BitefightProject
{
    public partial class Main : Form
    {
        public static string AccountID = "";
        public static dynamic Settings = new IniFile("Settings.ini");
        public string SelectedServer = "";
        public static bool IsRunning = false;
        public static bool IsFirstLogin = false;
        public static bool FetchUserData = false;
        public static bool IsFakeLogin = false;
        public static bool IsGrotteMenu = false;
        public int LatestStat = 0;
        public int LatestPlayer = 0;

        public Action frmAction = (Action)Application.OpenForms["frmAction"];

        #region API's
        [DllImport("wininet.dll")]
        static extern InternetCookieState InternetSetCookieEx(
       string lpszURL,
       string lpszCookieName,
       string lpszCookieData,
       int dwFlags,
       int dwReserved);

        enum InternetCookieState : int
        {
            COOKIE_STATE_UNKNOWN = 0x0,
            COOKIE_STATE_ACCEPT = 0x1,
            COOKIE_STATE_PROMPT = 0x2,
            COOKIE_STATE_LEASH = 0x3,
            COOKIE_STATE_DOWNGRADE = 0x4,
            COOKIE_STATE_REJECT = 0x5,
            COOKIE_STATE_MAX = COOKIE_STATE_REJECT
        }
        #endregion

        #region SendPacket
        public void SendPacket(WebBrowser Emu, string url)
        {
            string agent = Settings.Read("Browser", "Account" + AccountID);
            string temp = string.Format("User-Agent: {0}" + Environment.NewLine + "", agent);
            InternetSetCookieEx("https://" + comboServers.SelectedItem + url, null, Settings.Read("Cookie", "Account" + AccountID) + ";", 0, 0);
            Emu.Navigate(new Uri("https://" + comboServers.SelectedItem + url), "", null, temp);
        }

        public void SendActionPacket(WebBrowser Emu, string url, string postData = "")
        {
            byte[] postByteData = Encoding.UTF8.GetBytes(postData);
            string agent = Settings.Read("Browser", "Account" + AccountID);
            string temp = string.Format("User-Agent: {0}" + Environment.NewLine + "", agent);
            InternetSetCookieEx(url, null, Settings.Read("Cookie", "Account" + AccountID) + ";", 0, 0);
            Emu.Navigate(new Uri(url), "", postByteData, temp);
        }

        public void SendPacket(WebBrowser Emu, string url, string postData = "")
        {
            byte[] postByteData = Encoding.UTF8.GetBytes(postData);
            string agent = Settings.Read("Browser", "Account" + AccountID);
            string temp = string.Format("User-Agent: {0}" + Environment.NewLine + "", agent);
            InternetSetCookieEx("https://" + comboServers.SelectedItem + url, null, Settings.Read("Cookie", "Account" + AccountID) + ";", 0, 0);
            Emu.Navigate(new Uri(url), "", postByteData, temp);
        }
        #endregion

        #region Emulators
        private void EmulatorPlayerVsPlayer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("adventure") != -1 || e.Url.ToString().IndexOf("working") != -1)
            {
                LogWrite("Couldn't retrieve grotte information. Maybe you are on graveyard/story or something?");
                return;
            }

            if (IsRunning && checkPlayerVsPlayer.Checked)
            {
                //TODO:WhiteList ile alakalı hiç birşey eklenmedi zamanı gelince eklenecek
                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/robbery/index")//Oyuncu nickini black listten sorgulanır
                {
                    string[] PvPBlackList = Settings.Read("PvPBlacklist", "Account" + AccountID).Split(' ');
                    string InputName = "";
                    string InputData = "";
                    var Inputs = EmulatorPlayerVsPlayer.Document.GetElementsByTagName("input");
                    for (int i = 0; i < Inputs.Count; i++)
                    {
                        if (Inputs[i].GetAttribute("className") == "input" && Inputs[i].GetAttribute("maxlength") == "30")
                        {
                            InputName = Inputs[i].GetAttribute("name");
                            InputData = PvPBlackList[LatestPlayer].Substring(0, PvPBlackList[LatestPlayer].IndexOf("("));
                            break;
                        }
                    }
                    var Forms = EmulatorPlayerVsPlayer.Document.GetElementsByTagName("form");
                    for (int i = 0; i < Forms.Count; i++)
                    {
                        if (Forms[i].GetAttribute("action").IndexOf("robbery/index?__token") != -1)
                        {
                            string url = Forms[i].GetAttribute("action");
                            //TODO:namesearch=Hadi! diğer dillere uyarlanacak!
                            SendPacket(EmulatorPlayerVsPlayer, url, InputName + "=" + InputData + "&namesearch=Hadi!");
                            return;
                        }
                    }
                }
                else if (e.Url.ToString().IndexOf("https://" + comboServers.SelectedItem + "/robbery/index?") != -1)// oyuncuya saldırılır
                {
                    string[] PvPBlackList = Settings.Read("PvPBlacklist", "Account" + AccountID).Split(' ');
                    var Strongs = EmulatorPlayerVsPlayer.Document.GetElementsByTagName("strong");
                    if (Strongs.Count > 0)
                    {//bu oyuncuyla savaşıldıysa diğer oyuncuya geç! // TODO: Gelişitilecek
                        LogWrite(PvPBlackList[LatestPlayer] + " Passed");
                        LatestPlayer++;
                        if (LatestPlayer > PvPBlackList.Length - 1)
                            LatestPlayer = 0;
                        SendPacket(EmulatorPlayerVsPlayer, "/robbery/index");
                        return;
                    }


                    HtmlDocument ekrem = EmulatorPlayerVsPlayer.Document;
                    string attackID = "";
                    string payCheck = "";

                    var Inputs = EmulatorPlayerVsPlayer.Document.GetElementsByTagName("input");
                    for (int i = 0; i < Inputs.Count; i++)
                    {
                        if (Inputs[i].GetAttribute("name") == "attackID")
                        {
                            attackID = Inputs[i].GetAttribute("value");
                        }
                        if (Inputs[i].GetAttribute("name") == "payCheck")
                        {
                            payCheck = Inputs[i].GetAttribute("value");
                        }
                    }
                    var Forms = EmulatorPlayerVsPlayer.Document.GetElementsByTagName("form");
                    for (int i = 0; i < Forms.Count; i++)
                    {
                        if (Forms[i].GetAttribute("action").IndexOf("robbery/attack?__token") != -1)
                        {
                            string url = Forms[i].GetAttribute("action");
                            SendPacket(EmulatorPlayerVsPlayer, url, "attackID=" + attackID + "&payCheck=" + payCheck);
                            return;
                        }
                    }
                }
                else if (e.Url.ToString().IndexOf("https://" + comboServers.SelectedItem + "/report/fightreport/") != -1)// savaş raporu gelir
                {
                    string[] PvPBlackList = Settings.Read("PvPBlacklist", "Account" + AccountID).Split(' ');
                    //TODO:Hesap bilgileri güncellenecek.
                    LogWrite(PvPBlackList[LatestPlayer] + " Attacked");
                    LatestPlayer++;
                    if (LatestPlayer > PvPBlackList.Length - 1)
                        LatestPlayer = 0;
                    SendPacket(EmulatorPlayerVsPlayer, "/robbery/index");
                }
            }
        }

        private void EmulatorCure_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (IsRunning && checkAutoCure.Checked)
                {
                    if (e.Url.ToString().IndexOf("?__token") == -1)
                    {
                        int RequiredAP = 0;
                        var ss = EmulatorCure.Document.GetElementsByTagName("td");
                        for (int i = 0; i < ss.Count; i++)
                        {
                            if (ss[i].GetAttribute("align") == "left")
                            {
                                string str = ss[i].InnerHtml.Trim().Remove(0, ss[i].InnerHtml.Trim().IndexOf("<br>") + 4).Trim();
                                RequiredAP = Convert.ToInt32(str.Substring(0, str.IndexOf(" ")));
                            }
                        }
                        if (RequiredAP <= Convert.ToInt32(txtAPLimit2.Text))
                        {
                            var Forms = EmulatorCure.Document.GetElementsByTagName("form");
                            for (int i = 0; i < Forms.Count; i++)
                            {
                                if (Forms[i].GetAttribute("action").IndexOf("city/church/?__token") != -1)
                                {
                                    string url = Forms[i].GetAttribute("action");
                                    SendActionPacket(EmulatorCure, url);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            LogWrite("Auto Cure; Limit Exceeding");
                            timerAutoCure.Stop();
                            checkAutoCure.Checked = false;
                            return;
                        }
                     
                    }
                    else
                    {
                        timerAutoCure.Start();
                        LogWrite("Using cure");
                        return;
                    }
                }
            }
            catch
            {
                LogWrite("Veri Alınamadı");
                timerAutoCure.Stop();
                checkAutoCure.Checked = false;
                return;
            }
        }

        private void Emulator_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("working") != -1)
            {
                LogWrite("Couldn't retrieve grotte information. Maybe you are on graveyard/story or something?");
                return;
            }

            if (IsRunning && checkStory.Checked)
            {
                LoadAccountInfo(Emulator.Document);

                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/city/adventure/startquest")
                {//Hikaye'ye yeni başlama butonuna tıklandıgında startquest urlsinden devam ediyor diye..
                    SendPacket(Emulator, "/city/adventure");
                    return;
                }

                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/city/adventure")
                {
                    int Counter = 0;
                    int SelectedDecisionIndex = -1;
                    string OptionList = "";
                    int[] AppropriateOptions = new int[10];
                    string strPriorities = Settings.Read("StoryPriorities", "Account" + AccountID).ToString();
                    int[] Priorities = strPriorities.Split(' ').Select(int.Parse).ToArray();
                    string strBlackList = Settings.Read("StoryBlackList", "Account" + AccountID).ToString();
                    int[] BlackList = strBlackList.Split(' ').Select(int.Parse).ToArray();
                    int MinLife = int.Parse(Settings.Read("StoryMinLife", "Account" + AccountID).ToString());
                    int CurrentLife = int.Parse(lblHerz.Text.Substring(0, lblHerz.Text.IndexOf("/")).Replace("Health : ", String.Empty).Replace(".", String.Empty));
                    int CurrentAP = int.Parse(lblAP.Text.Substring(0, lblAP.Text.IndexOf("/")).Replace("Action points : ", String.Empty).Replace(".", String.Empty));

                    if (CurrentAP <= Convert.ToInt32(txtAPLimit.Text))
                    {
                        LogWrite("Waiting : AP Limit");
                        Stop();
                        Task.Factory.StartNew(() => PlayAlarm(2));
                        return;
                    }

                    var Options = Emulator.Document.GetElementsByTagName("a");
                    for (int i = 0; i < Options.Count; i++)
                    {
                        if (Options[i].GetAttribute("href").IndexOf("startquest") != -1)
                        {
                            if (CurrentAP >= 3)
                            {
                                SendPacket(Emulator, "/city/adventure/startquest");
                            }
                            else
                            {
                                LogWrite("Waiting : AP Limit");
                                Stop();
                                Task.Factory.StartNew(() => PlayAlarm(2));
                            }
                            return;
                        }
                        else if (Options[i].GetAttribute("href").IndexOf("decision") != -1)
                        {
                            if (Options[i].GetAttribute("href") != null)
                            {
                                if (CurrentLife > MinLife)
                                {
                                    int start = Options[i].GetAttribute("href").IndexOf("decision") + 9;
                                    int lenght = Options[i].GetAttribute("href").Length - start;
                                    int id = int.Parse(Options[i].GetAttribute("href").Substring(start, lenght));
                                    bool IsBlack = false;

                                    OptionList += id + ",";
                                    for (int k = 0; k < BlackList.Length; k++)
                                    {
                                        if (id == BlackList[k])
                                        {
                                            IsBlack = true;
                                            break;
                                        }
                                    }
                                    if (IsBlack == false)
                                    {
                                        AppropriateOptions[Counter] = id;
                                        Counter++;
                                    }
                                }
                                else
                                {
                                    timerAccountInfo.Start();
                                    Task.Factory.StartNew(() => PlayAlarm(2));
                                    return;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < Priorities.Length; i++)
                    {
                        if (SelectedDecisionIndex != -1)
                        {
                            break;
                        }
                        for (int k = 0; k < AppropriateOptions.Length; k++)
                        {
                            if (Priorities[i] == AppropriateOptions[k])
                            {
                                SelectedDecisionIndex = k;
                                break;
                            }
                        }
                    }
                    if (SelectedDecisionIndex == -1)
                    {
                        if (AppropriateOptions[0] != 0)
                        {
                            StoryLogWrite(OptionList.Substring(0, OptionList.Length - 1), AppropriateOptions[0].ToString());
                            SendPacket(Emulator, "/city/adventure/decision/" + AppropriateOptions[0]);
                        }
                        else
                        {// Eğer tüm seçenekler black listte varsa black listin ilk sırasında olana git
                            int[] arrayOptionList = OptionList.Substring(0, OptionList.Length - 1).Split(',').Select(int.Parse).ToArray();
                            for (int i = 0; i < BlackList.Length; i++)
                            {
                                if (SelectedDecisionIndex != -1)
                                {
                                    StoryLogWrite(OptionList.Substring(0, OptionList.Length - 1), arrayOptionList[SelectedDecisionIndex].ToString());
                                    SendPacket(Emulator, "/city/adventure/decision/" + arrayOptionList[SelectedDecisionIndex]);
                                    break;
                                }
                                for (int k = 0; k < arrayOptionList.Length; k++)
                                {
                                    if (BlackList[i] == arrayOptionList[k])
                                    {
                                        SelectedDecisionIndex = k;
                                        break;
                                    }
                                }
                            }
                        }
                        return;
                    }
                    else
                    {
                        StoryLogWrite(OptionList.Substring(0, OptionList.Length - 1), AppropriateOptions[SelectedDecisionIndex].ToString());
                        SendPacket(Emulator, "/city/adventure/decision/" + AppropriateOptions[SelectedDecisionIndex]);
                        return;
                    }
                }
                if (e.Url.ToString().IndexOf("https://" + comboServers.SelectedItem + "/city/adventure/decision") != -1)
                {
                    SendPacket(Emulator, "/city/adventure");
                }
            }
        }

        private void EmulatorGoldAPFeature_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IsRunning && checkAutoStat.Checked)
            {
                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/profile/index")
                {
                    LoadStatInfo(EmulatorGoldAPFeature.Document);
                    int currentgold = int.Parse(lblRes2.Text.Replace("Gold : ", String.Empty).Replace(".", String.Empty));
                    int reqgold = 0;
                    int forcecost = int.Parse(lblForceCost.Text.Replace("Force Cost : ", String.Empty).Replace(".", String.Empty));
                    int defencecost = int.Parse(lblDefenceCost.Text.Replace("Defence Cost : ", String.Empty).Replace(".", String.Empty));
                    int dexteritycost = int.Parse(lblDexterityCost.Text.Replace("Dexterity Cost : ", String.Empty).Replace(".", String.Empty));
                    int endurancecost = int.Parse(lblEnduranceCost.Text.Replace("Endurance Cost : ", String.Empty).Replace(".", String.Empty));
                    int charismacost = int.Parse(lblCharismaCost.Text.Replace("Charisma Cost : ", String.Empty).Replace(".", String.Empty));
                    string[] GoldAPFeature = Settings.Read("AutoStats", "Account" + AccountID).Split(' ');
                    int lateststat = Convert.ToInt16(Settings.Read("AutoStatsCounter", "Account" + AccountID).ToString());
                    if (lateststat >= GoldAPFeature.Length)
                    {
                        lateststat = 0;
                    }
                    string statname = GoldAPFeature[lateststat];
                    string statid = "";
                    switch (statname)
                    {
                        case "Strength":
                            reqgold = forcecost;
                            statid = "1";
                            break;
                        case "Defense":
                            reqgold = defencecost;
                            statid = "2";
                            break;
                        case "Dexterity":
                            reqgold = dexteritycost;
                            statid = "3";
                            break;
                        case "Endurance":
                            reqgold = endurancecost;
                            statid = "4";
                            break;
                        case "Charisma":
                            reqgold = charismacost;
                            statid = "5";
                            break;
                    }
                    //LogWrite(String.Format("Stat ID : {0} / Şuanki para : {1} / İstenilen Para : {2}", statid, currentgold, reqgold));
                    if (currentgold > reqgold)
                    {
                        var Buttons = EmulatorGoldAPFeature.Document.GetElementsByTagName("a");
                        for (int i = 0; i < Buttons.Count; i++)
                        {

                            if (Buttons[i].GetAttribute("href").IndexOf("https://" + comboServers.SelectedItem + "/profile/training") != -1)
                            {
                                if (Buttons[i].GetAttribute("href").IndexOf("https://" + comboServers.SelectedItem + "/profile/training/" + statid) != -1)
                                {
                                    Settings.Write("AutoStatsCounter", (lateststat + 1).ToString(), "Account" + AccountID);
                                    int start = Buttons[i].GetAttribute("href").IndexOf("/profile");
                                    string url = Buttons[i].GetAttribute("href").Substring(start, Buttons[i].GetAttribute("href").Length - start);
                                    LogWrite("Using stat = " + statname);
                                    SendPacket(EmulatorUsingStat, url);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        SendPacket(EmulatorGoldAPFeature, "/profile/index");
                    }
                }
            }
        }
        private void EmulatorUsingStat_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IsRunning && checkAutoStat.Checked)
            {
                var Meta = EmulatorUsingStat.Document.GetElementsByTagName("meta");
                for (int i = 0; i < Meta.Count; i++)
                {
                    if (Meta[i].OuterHtml.IndexOf("Refresh") != -1)
                    {
                        SendPacket(EmulatorUsingStat, "/profile/index");
                    }
                }
                if (e.Url.ToString().IndexOf("/profile/index") != -1)
                {
                    SendPacket(EmulatorGoldAPFeature, "/profile/index");
                }
            }
        }

        private void EmulatorHumanHunt_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("adventure") != -1 || e.Url.ToString().IndexOf("working") != -1)
            {
                LogWrite("Couldn't retrieve grotte information. Maybe you are on graveyard/story or something?");
                return;
            }
            if (IsRunning && checkHumanHunt.Checked)
            {
                if (e.Url.ToString().IndexOf("/robbery/index") != -1)
                {
                    if (comboHumanHunt.SelectedIndex != -1)
                    {
                        if (Convert.ToInt32(txtHumanHuntCount.Text) > 0)
                        {
                            SendPacket(EmulatorHumanHunt, "/robbery/humanhunt/" + Convert.ToInt16(comboHumanHunt.SelectedIndex + 1));
                            return;
                        }
                        else
                        {
                            Stop();
                            return;
                        }
                    }
                }
                else if (e.Url.ToString().IndexOf("/report/fightreport/") != -1 || e.Url.ToString().IndexOf("/robbery/humanhunt/") != -1)
                {
                    LoadAccountInfo(EmulatorHumanHunt.Document);
                    LogWrite(txtHumanHuntCount.Text + ". Hunted");
                    txtHumanHuntCount.Text = Convert.ToString(Convert.ToInt32(txtHumanHuntCount.Text) - 1);
                    if (Convert.ToInt32(txtHumanHuntCount.Text) > 0)
                    {
                        SendPacket(EmulatorHumanHunt, "/robbery/humanhunt/" + Convert.ToInt16(comboHumanHunt.SelectedIndex + 1));
                        return;
                    }
                    else
                    {
                        Stop();
                        return;
                    }
                }
                else if (e.Url.ToString().IndexOf("/city/adventure") != -1)
                {
                    LogWrite("When making a story, you can not hunt.");
                    Stop();
                    return;
                }
            }
        }

        private void EmulatorGrotte_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("adventure") != -1 || e.Url.ToString().IndexOf("working") != -1)
            {
                LogWrite("Couldn't retrieve grotte information. Maybe you are on graveyard/story or something?");
                return;
            }
            if (checkGrotte.Checked)
            {
                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/city/grotte")
                {
                    if (!IsGrotteMenu)
                    {
                        var Inputs = EmulatorGrotte.Document.GetElementsByTagName("input");
                        for (int i = 0; i < Inputs.Count; i++)
                        {
                            if (Inputs[i].GetAttribute("className") == "btn-small left" && Inputs[i].GetAttribute("name") == "difficulty")
                            {
                                comboGrotte.Items.Add(Inputs[i].GetAttribute("value"));
                            }
                        }
                        IsGrotteMenu = true;
                    }
                    else if (IsGrotteMenu && IsRunning && Convert.ToInt16(txtGrotteCount.Text) > 0)
                    {
                        string FormAction = "";
                        var Forms = EmulatorGrotte.Document.GetElementsByTagName("form");
                        for (int i = 0; i < Forms.Count; i++)
                        {
                            if (Forms[i].GetAttribute("className") == "clearfix")
                            {
                                FormAction = Forms[i].GetAttribute("action");
                                break;
                            }
                        }
                        var Inputs = EmulatorGrotte.Document.GetElementsByTagName("input");
                        for (int i = 0; i < Inputs.Count; i++)
                        {
                            if (Inputs[i].GetAttribute("className") == "btn-small left" && Inputs[i].GetAttribute("name") == "difficulty" && Inputs[i].GetAttribute("value") == comboGrotte.SelectedItem.ToString())
                            {
                                SendPacket(EmulatorGrotte, FormAction, "difficulty=" + Inputs[i].GetAttribute("value"));
                                return;
                            }
                        }
                    }
                    else
                    {
                        Stop();
                    }
                }
                else if (e.Url.ToString().IndexOf("/report/fightreport") != -1)
                {
                    LogWrite(txtGrotteCount.Text + ". Grotte Successfuly.");
                    txtGrotteCount.Text = Convert.ToString(Convert.ToInt16(txtGrotteCount.Text) - 1);
                    SendPacket(EmulatorGrotte, "/city/grotte");
                }
            }

        }

        private void EmulatorGraveyard_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("adventure") != -1 || e.Url.ToString().IndexOf("working") != -1)
            {
                LogWrite("Couldn't retrieve grotte information. Maybe you are on graveyard/story or something?");
                return;
            }
            if (IsRunning && checkGraveyard.Checked)
            {
                if (e.Url.ToString() == "https://" + comboServers.SelectedItem + "/city/graveyard" && Convert.ToInt16(txtGraveyardCount.Text) > 0)
                {
                    string FormAction = "";
                    var Forms = EmulatorGraveyard.Document.GetElementsByTagName("form");
                    FormAction = Forms[0].GetAttribute("action");
                    SendPacket(EmulatorGraveyard, FormAction, "workDuration=" + comboGraveyard.SelectedItem.ToString().Substring(0, 1));
                    timerGraveyardWait.Interval = 3600000 * Convert.ToInt16(comboGraveyard.SelectedItem.ToString().Substring(0, 1));
                    timerGraveyardWait.Start();
                    LogWrite(txtGraveyardCount.Text + ". Entered the graveyard");
                }
                else
                {
                    Stop();
                }
            }
        }


        #endregion

        #region Timers
        private void timerGraveyardWait_Tick(object sender, EventArgs e)
        {
            timerGraveyardWait.Stop();
            LogWrite(txtGraveyardCount.Text + ". Finished the graveyard");
            int count = Convert.ToInt16(txtGraveyardCount.Text);
            txtGraveyardCount.Text = (count--).ToString();
            SendPacket(EmulatorGraveyard, "/city/graveyard");
        }

        private void timerAccountInfo_Tick(object sender, EventArgs e)
        {
            int MinLife = int.Parse(Settings.Read("StoryMinLife", "Account" + AccountID).ToString());
            int CurrentLife = int.Parse(lblHerz.Text.Substring(0, lblHerz.Text.IndexOf("/")).Replace("Health : ", String.Empty).Replace(".", String.Empty));
            int CurrentAP = int.Parse(lblAP.Text.Substring(0, lblAP.Text.IndexOf("/")).Replace("Action points : ", String.Empty).Replace(".", String.Empty));
            SendPacket(Emulator, "/profile");
            if (CurrentLife > MinLife)
            {
                if (CurrentAP >= Convert.ToInt32(txtAPLimit.Text))
                {
                    SendPacket(Emulator, "/city/adventure/startquest");
                    timerAccountInfo.Stop();
                }
                else
                {
                    LogWrite("Waiting : AP Limit");
                    Stop();
                }
            }
            else
            {
                LogWrite("Waiting : Start-Minimum Life");
                Stop();
            }
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            if (EmulatorLogin.ReadyState == WebBrowserReadyState.Complete || EmulatorLogin.ReadyState == WebBrowserReadyState.Interactive)
            {
                if (EmulatorLogin.Document != null)
                {
                    var Control = EmulatorLogin.Document.GetElementById("pwlostLink");
                    if (Control != null)
                    {
                        timerLogin.Stop();
                        LogWrite("Please enter the game from the browser.");
                        if (MessageBox.Show("Please enter the game from the browser.") == DialogResult.OK)
                            timerLogin.Start();
                        IsFirstLogin = true;
                    }
                    else
                    {
                        Control = EmulatorLogin.Document.GetElementById("character_tab");
                        if (Control != null)
                        {
                            timerLogin.Stop();
                            LogWrite("Vaow. Game injected bitefight ready.");
                            IsFirstLogin = true;
                        }
                    }
                }
            }
            if (IsFirstLogin)
            {
                checkStory.Enabled = true;
                checkPlayerVsPlayer.Enabled = true;
                checkAutoStat.Enabled = true;
                checkAutoCure.Enabled = true;
                txtAPLimit.Enabled = true;
                txtAPLimit2.Enabled = true;
                groupHumanHunt.Enabled = true;
                groupGrotte.Enabled = true;
                //groupGraveyard.Enabled = true;

                var Control = EmulatorLogin.Document.GetElementById("pwlostLink");
                if (Control == null)
                {
                    var Tags = EmulatorLogin.Document.GetElementsByTagName("a");
                    for (int i = 0; i < Tags.Count; i++)
                    {
                        if (Tags[i].GetAttribute("href").IndexOf("/profile/player/") != -1)
                        {
                            int LicenseCount = FormTools.LicenseControl(Tags[i].InnerText);

                            this.Text = "BiteFight Bot" + " - " + Tags[i].InnerText + " - " + (LicenseCount > 0 ? LicenseCount + " days left" : "your license expired");

                            if (LicenseCount > 0)
                            {
                                btnStart.Enabled = true;
                            }
                            btnStop.Enabled = false;

                            LoadAccountInfo(EmulatorLogin.Document);
                            LoadStatInfo(EmulatorLogin.Document);
                            LoadProfilePhoto(EmulatorLogin.Document);

                            LogWrite("Successfully logged in.");
                            timerLogin.Stop();
                        }
                    }
                }
            }
        }
        #endregion

        #region LoadFunctions
        public void LoadAccounts()
        {
            comboServers.Items.Clear();
            int counter = 0;
            while (true)
            {
                if (Settings.KeyExists("Server", "Account" + counter))
                {
                    comboServers.Items.Add(Settings.Read("Server", "Account" + counter));
                    counter++;
                }
                else
                {
                    break;
                }
            }
        }

        private void LoadStatInfo(HtmlDocument doc)
        {
            int StatCounter = 0;
            var triggerTooltips = doc.GetElementsByTagName("div");
            for (int i = 0; i < triggerTooltips.Count; i++)
            {
                if (triggerTooltips[i].GetAttribute("className") == "tooltip")
                {

                    string lines = triggerTooltips[i].InnerHtml + "\r\n";
                    if (triggerTooltips[i].InnerHtml.IndexOf("Fiyat:") != -1)
                    {
                        string temp = "", temp2 = "";
                        int bitis = -1;
                        if (triggerTooltips[i].InnerHtml.IndexOf("<img") != -1)
                        {
                            bitis = triggerTooltips[i].InnerHtml.IndexOf("<img");
                        }
                        else
                        {
                            bitis = triggerTooltips[i].InnerHtml.IndexOf("<IMG");
                        }
                        temp = triggerTooltips[i].InnerHtml.Substring(0, bitis);
                        int baslangic = triggerTooltips[i].InnerHtml.IndexOf("Fiyat:") + 7;
                        temp2 = temp.Substring(baslangic, temp.Length - baslangic);
                        if (StatCounter == 0)
                        {
                            lblForceCost.Text = "Force Cost : " + temp2;
                        }
                        else if (StatCounter == 1)
                        {
                            lblDefenceCost.Text = "Defence Cost : " + temp2;
                        }
                        else if (StatCounter == 2)
                        {
                            lblDexterityCost.Text = "Dexterity Cost : " + temp2;
                        }
                        else if (StatCounter == 3)
                        {
                            lblEnduranceCost.Text = "Endurance Cost : " + temp2;
                        }
                        else if (StatCounter == 4)
                        {
                            lblCharismaCost.Text = "Charisma Cost : " + temp2;
                        }
                        StatCounter++;
                    }
                }
            }
        }

        private void LoadAccountInfo(HtmlDocument doc)
        {
            string data = "";
            var result = doc.GetElementsByTagName("div");
            for (int k = 0; k < result.Count; k++)
            {
                if (result[k].GetAttribute("className") == "gold")
                {
                    data = result[k].InnerHtml;
                    break;
                }
            }


            data = data.Replace("&nbsp;", String.Empty);
            data = data.Replace(" ", String.Empty);
            data = data.Replace('"', '?');

            data = data.Replace("<IMGborder=0alt=Altınsrc=?/img/symbols/res2.gif?align=absMiddle>", "?");
            data = data.Replace("<IMGborder=0alt=?CehennemTaşı?src=?/img/symbols/res3.gif?align=absMiddle></A>", "?");
            data = data.Replace("<IMGborder=0alt=Parçasrc=?/img/symbols/res_splinters.png?align=absMiddle></A>", "?");
            data = data.Replace("<IMGborder=0alt=?FaaliyetPuanları?src=?/img/symbols/ap.gif?align=absMiddle>", "?");
            data = data.Replace("<IMGborder=0alt=?YaşamEnerjisi?src=?/img/symbols/herz.png?align=absMiddle><IMGborder=0alt=Kademesrc=?/img/symbols/level.gif?align=absMiddle>", "?");
            data = data.Replace("<IMGborder=0alt=?DövüşDeğeri?src=?/img/symbols/fightvalue.gif?align=absMiddle>", "?");

            data = data.Replace("<IMGborder=0alt=Altınalign=absMiddlesrc=?/img/symbols/res2.gif?>", "?");
            data = data.Replace("<IMGborder=0alt=?CehennemTaşı?align=absMiddlesrc=?/img/symbols/res3.gif?></A>", "?");
            data = data.Replace("<IMGborder=0alt=Parçaalign=absMiddlesrc=?/img/symbols/res_splinters.png?></A>", "?");
            data = data.Replace("<IMGborder=0alt=?FaaliyetPuanları?align=absMiddlesrc=?/img/symbols/ap.gif?>", "?");
            data = data.Replace("<IMGborder=0alt=?YaşamEnerjisi?align=absMiddlesrc=?/img/symbols/herz.png?><IMGborder=0alt=Kademealign=absMiddlesrc=?/img/symbols/level.gif?>", "?");
            data = data.Replace("<IMGborder=0alt=?DövüşDeğeri?align=absMiddlesrc=?/img/symbols/fightvalue.gif?>", "?");

            data = data.Replace("<imgalign=?absmiddle?alt=?Altın?src=?/img/symbols/res2.gif?border=?0?>", "?");
            data = data.Replace("<imgalign=?absmiddle?alt=?CehennemTaşı?src=?/img/symbols/res3.gif?border=?0?>", "?");
            data = data.Replace("<imgalign=?absmiddle?alt=?Parça?src=?/img/symbols/res_splinters.png?border=?0?>", "?");
            data = data.Replace("<imgalign=?absmiddle?alt=?FaaliyetPuanları?src=?/img/symbols/ap.gif?border=?0?>", " ?");
            data = data.Replace("<imgalign=?absmiddle?alt=?YaşamEnerjisi?src=?/img/symbols/herz.png?border=?0?>", "?");
            data = data.Replace("<imgalign=?absmiddle?alt=?Kademe?src=?/img/symbols/level.gif?border=?0?>", "");
            data = data.Replace("<imgalign=?absmiddle?alt=?DövüşDeğeri?src=?/img/symbols/fightvalue.gif?border=?0?>", "?");

            string[] AccountInfo = data.Split('?');
            lblRes2.Text = "Gold : " + AccountInfo[0].Trim();
            lblRes3.Text = "Hellstones : " + AccountInfo[1].Trim();
            lblResSplinters.Text = "Fragments : " + AccountInfo[2].Trim();
            lblAP.Text = "Action points : " + AccountInfo[3].Trim();
            lblHerz.Text = "Health : " + AccountInfo[4].Trim();
            lblLevel.Text = "Level : " + AccountInfo[5].Trim();
            lblFightValue.Text = "Battle value : " + AccountInfo[6].Trim();
        }

        private void LoadProfilePhoto(HtmlDocument doc)
        {
            var result = doc.GetElementsByTagName("img");
            for (int k = 0; k < result.Count; k++)
            {
                if (result[k].GetAttribute("alt") == "playerlogo")
                {
                    pictureBox1.ImageLocation = result[k].GetAttribute("src");
                    break;
                }
            }
        }
        #endregion

        public Main()
        {
            InitializeComponent();
            var path = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            var browserEmulationValue = 11001;
            var appName = System.AppDomain.CurrentDomain.FriendlyName;
            if (Registry.CurrentUser.OpenSubKey(path).GetValue(appName) == null)
                Registry.CurrentUser.OpenSubKey(path, true).SetValue(appName, browserEmulationValue, RegistryValueKind.DWord);
            UnmanagedCode.disableSound();
            Emulator.ScriptErrorsSuppressed = true;
            EmulatorLogin.ScriptErrorsSuppressed = true;
            EmulatorGoldAPFeature.ScriptErrorsSuppressed = true;
            EmulatorUsingStat.ScriptErrorsSuppressed = true;
            EmulatorPlayerVsPlayer.ScriptErrorsSuppressed = true;
            EmulatorHumanHunt.ScriptErrorsSuppressed = true;
            EmulatorGrotte.ScriptErrorsSuppressed = true;
            EmulatorGraveyard.ScriptErrorsSuppressed = true;
            lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboGraveyard.SelectedIndex = 0;
            comboHumanHunt.SelectedIndex = 0;
            //Settings.ini eğer yoksa oluştur.
            if (!File.Exists(Application.StartupPath + "//" + "Settings.ini"))
            {
                File.Create(Application.StartupPath + "//" + "Settings.ini");
            }
            LoadAccounts();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            checkStory.Enabled = true;
            checkPlayerVsPlayer.Enabled = true;
            checkAutoStat.Enabled = true;
            txtAPLimit.Enabled = true;
            groupHumanHunt.Enabled = true;
            //groupGrotte.Enabled = true;
            //groupGraveyard.Enabled = true;

            Stop();
        }

        private void Stop()
        {
            txtHumanHuntCount.Enabled = true;
            comboHumanHunt.Enabled = true;
            //txtGrotteCount.Enabled = true;
            //comboGrotte.Enabled = true;

            LogWrite("The program was stopped.");
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            timerAccountInfo.Stop();
            timerLogin.Stop();
            IsRunning = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                if (comboServers.SelectedIndex != -1)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;

                    var Control = EmulatorLogin.Document.GetElementById("pwlostLink");
                    if (Control == null)
                    {
                        IsRunning = true;
                        if (checkStory.Checked)
                        {
                            SendPacket(Emulator, "/city/adventure");
                        }
                        else if (checkPlayerVsPlayer.Checked)
                        {
                            SendPacket(EmulatorPlayerVsPlayer, "/robbery/index");
                        }
                        else if (checkHumanHunt.Checked)
                        {
                            comboHumanHunt.Enabled = false;
                            txtHumanHuntCount.Enabled = false;
                            SendPacket(EmulatorHumanHunt, "/robbery/index");
                        }
                        else if (checkGrotte.Checked)
                        {
                            if (comboGrotte.SelectedIndex != -1)
                            {
                                comboGrotte.Enabled = false;
                                txtGrotteCount.Enabled = false;
                                SendPacket(EmulatorGrotte, "/city/grotte");
                            }
                            else
                            {
                                Stop();
                                MessageBox.Show("Please select difficulty level");
                            }
                        }
                        else if (checkGraveyard.Checked)
                        {
                            SendPacket(EmulatorGraveyard, "/city/graveyard");
                        }
                        if (checkAutoStat.Checked)
                        {
                            SendPacket(EmulatorGoldAPFeature, "/profile/index");
                        }
                        if (checkAutoCure.Checked)
                        {
                            timerAutoCure.Start();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select server!");
                    return;
                }
            }
        }

        private void StoryLogWrite(string Text, string id)
        {
            string[] ekrem = { id + " -> " + FormTools.GetButtonText(id) + "(" + Text + ")" + " - " + FormTools.GetStoryCurrentCount(Emulator.Document) };
            ListViewItem log = new ListViewItem(ekrem);
            listLogs.Items.Add(log);
            listLogs.SelectedIndices.Clear();
            listLogs.FocusedItem = listLogs.Items[listLogs.Items.Count - 1];
            listLogs.FocusedItem.Selected = true;
            listLogs.BeginInvoke((MethodInvoker)delegate { listLogs.FocusedItem.EnsureVisible(); });
        }

        private void LogWrite(string Text)
        {
            string[] ekrem = { Text };
            ListViewItem log = new ListViewItem(ekrem);
            listLogs.Items.Add(log);
            listLogs.SelectedIndices.Clear();
            listLogs.FocusedItem = listLogs.Items[listLogs.Items.Count - 1];
            listLogs.FocusedItem.Selected = true;
            listLogs.BeginInvoke((MethodInvoker)delegate { listLogs.FocusedItem.EnsureVisible(); });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectedServer = "";
            Action frmAction = new Action();
            frmAction.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (comboServers.SelectedIndex != -1)
            {
                SelectedServer = comboServers.SelectedItem.ToString();
                Action frmAction = new Action();
                frmAction.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select server!");
                return;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            Settings.DeleteSection("Account" + FormTools.GetAccountID(comboServers.SelectedItem.ToString()));
            LoadAccounts();
        }


        private void checkPlayerVsPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlayerVsPlayer.Checked)
            {
                checkStory.Checked = false;
                checkHumanHunt.Checked = false;
                checkGrotte.Checked = false;
            }
        }

        private void checkStory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStory.Checked)
            {
                checkPlayerVsPlayer.Checked = false;
                checkHumanHunt.Checked = false;
                checkGrotte.Checked = false;
                checkGraveyard.Checked = false;
            }
        }

        private void checkHumanHunt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHumanHunt.Checked)
            {
                checkStory.Checked = false;
                checkPlayerVsPlayer.Checked = false;
                checkGrotte.Checked = false;
                checkGraveyard.Checked = false;
            }
        }

        private void checkGrotte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGrotte.Checked)
            {
                if (IsFirstLogin)
                {
                    checkStory.Checked = false;
                    checkPlayerVsPlayer.Checked = false;
                    checkHumanHunt.Checked = false;
                    checkGraveyard.Checked = false;
                    SendPacket(EmulatorGrotte, "/city/grotte");
                }
                else
                {
                    checkGrotte.Checked = false;
                    MessageBox.Show("Please activate cookies");
                }
            }

        }

        private void checkGraveyard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGraveyard.Checked)
            {
                checkStory.Checked = false;
                checkPlayerVsPlayer.Checked = false;
                checkHumanHunt.Checked = false;
                checkGrotte.Checked = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (comboServers.SelectedIndex != -1)
            {
                int counter = 0;
                while (true)
                {
                    if (Settings.KeyExists("Server", "Account" + counter))
                    {
                        if (comboServers.SelectedItem.ToString() == Settings.Read("Server", "Account" + counter).ToString())
                        {
                            AccountID = counter.ToString();
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                if (!IsRunning)
                {
                    if (comboServers.SelectedIndex != -1)
                    {
                        LogWrite("Program is starting.");
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        LogWrite("Logging in.");
                        SendPacket(EmulatorLogin, "/user/login");
                    }
                    else
                    {
                        MessageBox.Show("Please select server!");
                        return;
                    }
                }
            }
        }

        private void EmulatorLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (EmulatorLogin.ReadyState == WebBrowserReadyState.Complete || EmulatorLogin.ReadyState == WebBrowserReadyState.Interactive)
            {
                if (EmulatorLogin.Document != null)
                {
                    if (EmulatorLogin.Document.All.Count > 250)
                    {
                        timerLogin.Start();
                    }
                }
            }
        }

        public static void PlayAlarm(int Replay)
        {
            try
            {
                SoundPlayer alarm = new SoundPlayer();
                alarm.SoundLocation = Application.StartupPath + "\\alarm.wav";
                for (int i = 0; i < Replay; i++)
                {
                    alarm.Play();
                    Thread.Sleep(2000);
                }
            }
            catch { }
        }

        private void timerAutoCure_Tick(object sender, EventArgs e)
        {
            int MinLife = int.Parse(Settings.Read("StoryMinLife", "Account" + AccountID).ToString());
            int CurrentLife = int.Parse(lblHerz.Text.Substring(0, lblHerz.Text.IndexOf("/")).Replace("Health : ", String.Empty).Replace(".", String.Empty));
            if (CurrentLife <= MinLife)
            {
                SendPacket(EmulatorCure, "/city/church");
            }
            SendPacket(EmulatorCure, "/city/church");
            timerAutoCure.Stop();
        }
    }
}
