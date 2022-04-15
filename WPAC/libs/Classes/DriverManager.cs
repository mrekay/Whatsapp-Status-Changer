using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static WPAC.libs.Config;
using static WPAC.Functions;
namespace WPAC.libs.Classes
{
    public class DriverManager
    {

        IWebDriver webDriver;
        ChromeOptions chromeSettings;
        public DriverManager()
        {
        }

        public async Task<bool> InitializeDriver(string _proxy)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            chromeSettings = new ChromeOptions();
            chromeSettings.AddExcludedArgument("enable-automation");
            chromeSettings.AddArgument("user-data-dir="+GetAppdataPath());
            chromeSettings.AddArgument("profile-directory=WPAC");
            if (BROWSER_MODE == "HEADLESS") chromeSettings.AddArgument("--headless");
            /*chromeSettings.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:92.0) Gecko/20100101 Firefox/6.0");*/
            if (!string.IsNullOrEmpty(_proxy))
            {
                chromeSettings.AddArguments("-proxy-server=" + _proxy);
            }
            webDriver = new ChromeDriver(chromeDriverService, chromeSettings);
            if (BROWSER_MODE == "MINIMIZED")  webDriver.Manage().Window.Minimize();
            await Task.Delay(2000);
            return (webDriver != null);
        }

        public async void Navigate(string URL)
        {
            try { 
            if (!isDriverDisposed())
                webDriver.Navigate().GoToUrl(URL);
                await Task.Delay(500);
            }
            catch { await Task.Delay(500);  return; }
            
        }

        public void Refresh()
        {
            try
            {
                webDriver.Navigate().Refresh();
            }
            catch { throw; }
        }
        public async Task Die()
        {
            webDriver.Quit();
            webDriver = null;
        }
        public IWebDriver GetWebDriver()
        {
            try
            {
                return this.webDriver;
            }
            catch { throw; }
        }

        public bool isDriverDisposed()
        {
            bool isClosed = false;
            try
            {
                webDriver.Url.ToString();
            }
            catch
            {
                isClosed = true;
            }

            return isClosed;
        }

        public string runJavaScript(string javaScript)
        {
            try
            {
                if (javaScript == null) return null;

                string returVal = null;
                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                returVal = (string)js.ExecuteScript(javaScript);
                return returVal == null ? null : returVal;
            }
            catch
            {
                return null;
            }
        }

        public string getDocumentTitle()
        {
            try
            {
                return (string)this.webDriver.Title.ToString();
            }
            catch { throw; }
        }
        public string getUrl()
        {
            try
            {
                if (webDriver is null) return null;
                return this.webDriver.Url.ToString();
            }
            catch { return null; }
        }

        public void ClearCookies()
        {
            try
            {
                if (!isDriverDisposed())
                    webDriver.Manage().Cookies.DeleteAllCookies();
            }
            catch { throw; }
            Thread.Sleep(7000);
        }

        public IWebDriver getBrowser()
        {
            try
            {
                return this.webDriver;
            }
            catch { return null; }
        }

        public IWebElement getElementById(string id)
        {
            try
            {
                if (webDriver is null) return null;
                return this.webDriver.FindElement(By.Id(id));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string getClassNameById(string id)
        {
            try
            {
                if (webDriver is null) return "";
                return this.getElementById(id).GetAttribute("className");
            }
            catch { return ""; }
        }
        public bool setValueById(string id, string innerText)
        {
            try
            {
                if (this.isDriverDisposed()) return false;
                if (webDriver is null) return false;
                if (this.getElementById(id) is null) return false;
                this.getElementById(id).Clear();
                this.getElementById(id).SendKeys(innerText);
                return true;
            }
            catch { return false; }
        }
        public string getInnerTextById(string id)
        {
            try
            {
                if (webDriver is null) return "";
                if (this.getElementById(id) is null) return "";
                return this.getElementById(id).GetAttribute("innerText");
            }
            catch { return ""; }

        }
        public string getHtmlById(string id)
        {
            try
            {
                if (webDriver is null) return "";
                if (this.getElementById(id) is null) return "";
                return this.getElementById(id).GetAttribute("innerHTML");
            }
            catch { return ""; }
        }
        public void clickById(string id)
        {
            try
            {
                if (webDriver is null) return;
                if (this.getElementById(id) is null) return;
                this.getElementById(id).Click();
            }
            catch { return; }
        }

        public bool clickByClassName(string id)
        {
            try
            {
                if (webDriver is null) return false;
                this.webDriver.FindElement(By.ClassName(id)).Click();
                return true;
            }
            catch { return false; }
        }
    }
}
