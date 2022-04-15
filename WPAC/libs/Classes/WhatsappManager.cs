using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPAC.libs.Classes
{
    public class WhatsappManager
    {
        DriverManager driverMan;

        int messageKey = 0,
            OperationLevel = 1;

        System.Windows.Forms.Timer operationLevelCounter = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer nextOperationPlanner = new System.Windows.Forms.Timer();
        public bool isOperationCanceled = false,
             isReloading = false,
             isRunning = false;
        public WhatsappManager(DriverManager _driverMan)
        {
            driverMan = _driverMan;
            operationLevelCounter.Interval = 250;
            operationLevelCounter.Tick += OperationLevelCounter_Tick;   
            nextOperationPlanner.Interval = 2500;
            nextOperationPlanner.Tick += NextOperationPlanner_Tick;
            driverMan.Navigate("https://web.whatsapp.com");
        }

        private void NextOperationPlanner_Tick(object sender, EventArgs e)
        {
            nextOperationPlanner.Stop();
            OperationLevel = 0;
            isReloading = true;
            driverMan.Refresh();
            Operation();
        }

        private void OperationLevelCounter_Tick(object sender, EventArgs e)
        {
            operationLevelCounter.Stop();
            Operation();
        }

        public bool Run()
        {
            if (!WebWhatsappIsReady()) return false;
            isRunning = true;
            Operation();
            return true;
        }
        public bool Stop() {
            isOperationCanceled = true;
            isRunning = false;
            return true;
        }
        public void waitForNewOperation() {
            if (isOperationCanceled) { OperationLevel = 0; isOperationCanceled = false; messageKey = 0; return; }
            if (WebWhatsappIsReady()) { isReloading = false; Operation(); }
            else waitForNewOperation();
        }
        public void Operation()
        {
            if (!WebWhatsappIsReady() && !isReloading) { isRunning = false; return; } else if (isReloading) waitForNewOperation();
            if (isOperationCanceled) { OperationLevel = 0; isOperationCanceled = false; isRunning = false; messageKey = 0; return; }
            isReloading = false;

            if (OperationLevel == 1)
            {
                var user_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[3]/div/header/div[1]/div[1]/img"));
                user_button.Click();
            }
            else if (OperationLevel == 2)
            {
                var edit_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/span[2]/button/span"));
                edit_button.Click();
            } 
            else if (OperationLevel == 3)
            {
                var textbox = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/div/div/div[2]"));
                textbox.Click();                
            }else if (OperationLevel == 4)
            {
                var textbox = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/div/div/div[2]"));
                textbox.Clear();

                var statusMessage = getNewStatusMessage();
                textbox.SendKeys(statusMessage);
            }
            else if (OperationLevel == 5)
            {
                var save_button = driverMan.GetWebDriver().FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div[1]/span/div[1]/span/div[1]/div/div[4]/div[2]/div[1]/span[2]/button/span"));
                save_button.Click();
            }else if (OperationLevel == 6)
            {
                nextOperationPlanner.Start();
                return;
            }
            OperationLevel++;
            operationLevelCounter.Start();
        }

        private string getNewStatusMessage()
        {
            var countMessages =  Properties.Settings.Default.StatusMessages != null ? Properties.Settings.Default.StatusMessages.Count : 0;
            messageKey = messageKey >= countMessages ? 0 : messageKey;
            var returnVal = Properties.Settings.Default.StatusMessages != null ? Properties.Settings.Default.StatusMessages[messageKey] : Properties.Settings.Default.StatusMessages[0];
            
            messageKey++;
            return reWriteMessage(returnVal);
        }

        private string reWriteMessage(string message)
        {
            List<string[]> replacements = new List<string[]>();
            replacements.Add(new string[] { "{{TIME}}", DateTime.Now.ToString("HH:mm") });
            replacements.Add(new string[] { "{{DATE}}", DateTime.Now.ToString("dd/MM/yyyy") });
            replacements.Add(new string[] { "{{DATETIME}}", DateTime.Now.ToString() });
            foreach (string[] replacement in replacements)
            {
                message = message.Replace(replacement[0], replacement[1]);
            }

            return message;
        }

        public bool WebWhatsappIsReady()
        {
            try { 
                var element = driverMan.GetWebDriver().FindElement(By.Id("side"));
                Thread.Sleep(1500);
                if (element != null) return true;
            }
            catch
            {
                
            }
            return false;
        }
    }
}
