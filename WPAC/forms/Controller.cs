
using WPAC.libs.Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WPAC.libs.Config;

namespace WPAC.forms
{
    public partial class Controller : Form
    {
        public bool lock_secondary_check;
        public Controller()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            reloadListBox();
            driverMan.InitializeDriver(null);
            wpMan = new WhatsappManager(driverMan);
        }

        public void CheckOperation()
        {
            try
            {
                if (lock_secondary_check) return;
                var element = driverMan.GetWebDriver().FindElement(By.Id("side"));
                if (element != null) RunOperation();
                lock_secondary_check = true;
                return;
            }
            catch
            {
                Thread.Sleep(1500);
                CheckOperation();
            }
        }

        public void RunOperation()
        {
            var user_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[3]/div/header/div[1]/div[1]/img"));
            Thread.Sleep(100);
            user_button.Click();
            Thread.Sleep(100);
            var edit_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/span[2]/button/span"));
            Thread.Sleep(100);
            edit_button.Click();
            Thread.Sleep(100);
            var textbox = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/div/div/div[2]"));
            textbox.Click();
            Thread.Sleep(100);
            textbox.Clear();
            Thread.Sleep(100);
            textbox.SendKeys("809");
            Thread.Sleep(100);
            var save_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/span[2]/button/span"));
            Thread.Sleep(100);
            save_button.Click();
            Thread.Sleep(100);
        }

        #region "DriverManager"
        public bool initalized_status = false;
        DriverManager driverMan = new DriverManager();
        WhatsappManager wpMan;
        #endregion

        private void Controller_Load(object sender, EventArgs e)
        {
            lbl_controller_version.Text = lbl_controller_version.Text.Replace("{Version}", Application.ProductVersion);
        }

        public void reloadListBox()
        {
            lb_controller_main.Items.Clear();
            if (Properties.Settings.Default.StatusMessages == null) return;
            foreach (string message in Properties.Settings.Default.StatusMessages)
            {
                lb_controller_main.Items.Add(message);
            }
        }

        private void btn_lb_add_Click(object sender, EventArgs e)
        {
            AddStatus addStatus = new AddStatus();
            addStatus.ShowDialog();
            reloadListBox();
        }

        private void btn_lb_remove_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StatusMessages == null) return;
            DialogResult result = MessageBox.Show("Do you really want to remove this item?", "Approval required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Properties.Settings.Default.StatusMessages.Remove(lb_controller_main.SelectedItem.ToString());
                Properties.Settings.Default.Save();
            }
            reloadListBox();
        }

        private void btn_header_run_Click(object sender, EventArgs e)
        {
            if(wpMan.isRunning) wpMan.Stop();
            else wpMan.Run();
        }

        private void wpManWatcher_Tick(object sender, EventArgs e)
        {
            if (wpMan.isRunning)
            {
                btn_header_run.IconChar = FontAwesome.Sharp.IconChar.Stop;
                btn_header_run.IconColor = Color.IndianRed;
            }
            else { 
                btn_header_run.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_header_run.IconColor = Color.FromArgb(18, 140, 126);
            }
        }
        private void btn_controller_edit_Click(object sender, EventArgs e)
        {
            if (lb_controller_main.SelectedItems.Count<=0) return;
            var selectedID = lb_controller_main.SelectedIndex;
            AddStatus addStatus = new AddStatus(lb_controller_main.SelectedItem.ToString(),selectedID);
            addStatus.ShowDialog();
            reloadListBox();
        }

        private void Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            driverMan.Die();
            Environment.Exit(0);
        }
    }
}
