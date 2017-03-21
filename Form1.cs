using ExecuteJS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using ExecuteJS.Properties;
using System.Collections.Specialized;

namespace ExecuteJS
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        ArrayList listScripts = new ArrayList();

        int modifyIndex = 0;
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count > 0)
            {
                modifyIndex = listViewScripts.SelectedIndices[0];
                textBoxAddressScript.Text = listViewScripts.Items[modifyIndex].Text;
                textBoxScript.Text = listScripts[modifyIndex].ToString();
                panel2.Visible = true;
                panel2.BringToFront();
                buttonModifyUpdate.Visible = true;
            }
        }

        private void buttonNewScript_Click(object sender, EventArgs e)
        {
            //FormNewScript newScriptfrm = new FormNewScript();
            //newScriptfrm.Show();
            textBoxAddressScript.Clear();
            textBoxScript.Clear();
            panel2.Visible = true;
            panel2.BringToFront();
            buttonAddUpdate.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewScripts.SelectedItems.Count > 0)
            {
                int removeIndex = listViewScripts.SelectedIndices[0];
                listViewScripts.Items.RemoveAt(removeIndex);
                listScripts.RemoveAt(removeIndex);
            }
        }

        IWebDriver driver;

        public static string readControlText(ListView varControl, int index)
        {
            if (varControl.InvokeRequired)
            {
                return (string)varControl.Invoke(
                  new Func<String>(() => readControlText(varControl, index))
                );
            }
            else
            {
                string varText = varControl.Items[index].Text;
                return varText;
            }
        }

        public static bool getControlChecked(ListView varControl, int index)
        {
            if (varControl.InvokeRequired)
            {
                return (bool)varControl.Invoke(
                  new Func<bool>(() => getControlChecked(varControl, index))
                );
            }
            else
            {
                return varControl.Items[index].Checked;
            }
        }

        string previousUrl = "";
        void WaitForLoad(IWebDriver driver, int timeoutSec)
        {
            while (true)
            {
                Thread.Sleep(1000);
                try
                {
                    if (driver.Url != previousUrl)
                    {
                        IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSec));
                        wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
                        previousUrl = driver.Url;
                        //MessageBox.Show("Loaded");
                        int index = 0;
                        foreach (string item in listScripts)
                        {
                            string currentAddress = removeProtocol(readControlText(listViewScripts, index));
                            //MessageBox.Show(driver.Url + "\n" + currentAddress);
                            if (getControlChecked(listViewScripts, index) && removeProtocol(driver.Url).StartsWith(currentAddress))
                            {
                                string jsCode = listScripts[index].ToString();
                                //MessageBox.Show("Executing script");
                                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                                js.ExecuteScript(jsCode);
                            }
                            index++;
                        }
                        //MessageBox.Show("DOne");
                    }
                }
                catch (Exception ee) { }
            }
        }

        Thread t2;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        string removeProtocol(string Text)
        {
            System.Uri uri = new Uri(Text);
            string uriWithoutScheme = uri.Host + uri.PathAndQuery;
            return uriWithoutScheme;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.listViewAddresses != null)
                {
                    listViewScripts.Items.Clear();
                    foreach (string item in Settings.Default.listViewAddresses)
                    {
                        listViewScripts.Items.Add(item);
                    }
                }

                if (Settings.Default.listScripts != null)
                {
                    listScripts.Clear();
                    foreach (string item in Settings.Default.listScripts)
                    {
                        listScripts.Add(item);
                    }
                }

                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService, new ChromeOptions());
                driver.Manage().Window.Position = new Point(-1000, -1000);
                driver.Navigate().GoToUrl("http://www.google.com");

                string title = String.Format("{0} - Google Chrome", driver.Title);
                var process = Process.GetProcesses().FirstOrDefault(x => x.MainWindowTitle == title);

                SetParent(process.MainWindowHandle, panel3.Handle);
                driver.Manage().Window.Position = new Point(0, 0);
                driver.Manage().Window.Maximize();

                t2 = new Thread(delegate ()
                {
                    WaitForLoad(driver, 15);
                });
                t2.Start();
            }
            catch(Exception ee) { }
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            listViewScripts.Items.Add(textBoxAddressScript.Text);
            listScripts.Add(textBoxScript.Text);
            buttonAddUpdate.Visible = false;
            panel2.Visible = false;
        }

        private void buttonModifyUpdate_Click(object sender, EventArgs e)
        {
            listViewScripts.Items[modifyIndex].Text = textBoxAddressScript.Text;
            listScripts[modifyIndex] = textBoxScript.Text;
            buttonModifyUpdate.Visible = false;
            panel2.Visible = false;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.listViewAddresses = new StringCollection();
            foreach (ListViewItem item in listViewScripts.Items)
            {
                //MessageBox.Show(item.Text);
                Settings.Default.listViewAddresses.Add(item.Text);
            }

            Settings.Default.listScripts = new StringCollection();
            foreach (string item in listScripts)
                Settings.Default.listScripts.Add(item);

            Settings.Default.Save();

            try { driver.Quit(); }
            catch (Exception excep) { }
            t2.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonAddUpdate.Visible = false;
            buttonModifyUpdate.Visible = false;
            panel2.Visible = false;
        }
    }
}
