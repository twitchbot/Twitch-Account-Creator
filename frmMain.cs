using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using Microsoft.Win32;
namespace TwitchAccountCreator
{
    public partial class frmMain : Form
    {
        private IContainer _components;
        private Button strtbt;
        private WebBrowser wb;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button subbtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox acclb;
        private Button getcbtn;
        private GroupBox groupBox3;
        private Button refcbtn;
        private Button logbt;
        private Random ran = new Random();
        private string user = "";
        private string pass = "";
        private string em = "";
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this._components != null))
            {
                this._components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
            this.strtbt = new Button();
            this.wb = new WebBrowser();
            this.pictureBox1 = new PictureBox();
            this.textBox1 = new TextBox();
            this.subbtn = new Button();
            this.groupBox1 = new GroupBox();
            this.groupBox2 = new GroupBox();
            this.acclb = new ListBox();
            this.getcbtn = new Button();
            this.groupBox3 = new GroupBox();
            this.refcbtn = new Button();
            this.logbt = new Button();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.strtbt.Location = new Point(12, 13);
            this.strtbt.Name = "strtbt";
            this.strtbt.Size = new Size(75, 23);
            this.strtbt.TabIndex = 0;
            this.strtbt.Text = "Start";
            this.logbt.Location = new Point(268, 13);
            this.logbt.Name = "logbt";
            this.logbt.Size = new Size(65,23);
            this.logbt.TabIndex = 0;
            this.logbt.Text = "LogOut";
            this.strtbt.UseVisualStyleBackColor = true;
            this.strtbt.Click += new EventHandler(this.button1_Click);
            this.logbt.Click += new EventHandler(this.button5_Click);
            this.wb.Location = new Point(6, 19);
            this.wb.MinimumSize = new Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new Size(299, 75);
            this.wb.TabIndex = 3;
            this.wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            this.pictureBox1.Location = new Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(300, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.textBox1.Location = new Point(6, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(219, 20);
            this.textBox1.TabIndex = 6;
            this.subbtn.Location = new Point(231, 78);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new Size(75, 23);
            this.subbtn.TabIndex = 7;
            this.subbtn.Text = "Submit";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new EventHandler(this.button4_Click);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.subbtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(314, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captcha";
            this.groupBox2.Controls.Add(this.acclb);
            this.groupBox2.Location = new Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(314, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts";
            this.acclb.FormattingEnabled = true;
            this.acclb.Location = new Point(6, 19);
            this.acclb.Name = "acclb";
            this.acclb.Size = new Size(302, 82);
            this.acclb.TabIndex = 0;
            this.acclb.MouseDoubleClick += new MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.getcbtn.Enabled = false;
            this.getcbtn.Location = new Point(100, 13);
            this.getcbtn.Name = "getcbtn";
            this.getcbtn.Size = new Size(75, 23);
            this.getcbtn.TabIndex = 10;
            this.getcbtn.Text = "Captcha";
            this.getcbtn.UseVisualStyleBackColor = true;
            this.getcbtn.Click += new EventHandler(this.button2_Click);
            this.groupBox3.Controls.Add(this.wb);
            this.groupBox3.Location = new Point(13, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(313, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Web Browser";
            this.refcbtn.Enabled = false;
            this.refcbtn.Location = new Point(180, 13);
            this.refcbtn.Name = "refcbtn";
            this.refcbtn.Size = new Size(80, 23);
            this.refcbtn.TabIndex = 12;
            this.refcbtn.Text = "New Captcha";
            this.refcbtn.UseVisualStyleBackColor = true;
            this.refcbtn.Click += new EventHandler(this.refcbtn_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(339, 382);
            base.Controls.Add(this.refcbtn);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.getcbtn);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.strtbt);
            base.Controls.Add(this.logbt);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Name = "frmMain";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Twitch TV Account Creator";
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            base.ResumeLayout(false);
        }
        public  frmMain()
        {
            this.InitializeComponent();
        }
        public string RandomString(int length)
        {
            string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder stringBuilder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(text[this.ran.Next(text.Length)]);
            }
            return stringBuilder.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.clearC();
            this.getcbtn.Enabled = false;
            this.refcbtn.Enabled = false;
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Navigate("http://www.twitch.tv/signup/");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.clearC();
            this.getcbtn.Enabled = false;
            this.refcbtn.Enabled = false;
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Navigate("http://www.twitch.tv/logout/");
        }
        private void SetProxy(string proxies)
        {

            MessageBox.Show("Setting : " + proxies);
            string key = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

            RegistryKey RegKey = Registry.CurrentUser.OpenSubKey(key, true);
            RegKey.SetValue("ProxyServer", proxies);
            RegKey.SetValue("ProxyEnable", 0);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.getC();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.wb.Document.GetElementById("recaptcha_response_field").SetAttribute("value", this.textBox1.Text);
            this.wb.Document.GetElementById("subwindow_create_submit").InvokeMember("Click");
            this.textBox1.Text = "";
        }
        private void clearC()
        {
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            string[] array = files;
            for (int i = 0; i < array.Length; i++)
            {
                string path = array[i];
                try
                {
                    File.Delete(path);
                }
                catch
                {
                }
            }
        }
        private void getC()
        {
            HtmlElementCollection images = this.wb.Document.Images;
            foreach (HtmlElement htmlElement in images)
            {
                if (htmlElement.GetAttribute("alt").ToLower().Contains("recaptcha challenge ima"))
                {
                    string attribute = htmlElement.GetAttribute("src");
                    this.pictureBox1.Load(attribute);
                }
            }
        }
        private void setV(string username, string password, string email)
        {
            HtmlElementCollection all = this.wb.Document.All;
            foreach (HtmlElement htmlElement in all)
            {
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("user_login") && htmlElement.Name.ToLower().Equals("user[login]"))
                {
                    htmlElement.SetAttribute("value", username);
                }
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("user_password") && htmlElement.Name.ToLower().Equals("user[password]"))
                {
                    htmlElement.Focus();
                    htmlElement.SetAttribute("value", password + "A");
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("{TAB}");
                }
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("user_email") && htmlElement.Name.ToLower().Equals("user[email]"))
                {
                    htmlElement.SetAttribute("value", email);
                }
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("date_month") && htmlElement.Name.ToLower().Equals("date[month]"))
                {
                    htmlElement.Children[this.ran.Next(1, 7)].SetAttribute("selected", "selected");
                }
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("date_day") && htmlElement.Name.ToLower().Equals("date[day]"))
                {
                    htmlElement.Children[this.ran.Next(1, 7)].SetAttribute("selected", "selected");
                }
                if (htmlElement.Id != null && htmlElement.Id.ToLower().Equals("date_year") && htmlElement.Name.ToLower().Equals("date[year]"))
                {
                    htmlElement.Children[this.ran.Next(1, 12)].SetAttribute("selected", "selected");
                }
            }
        }
        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri == "http://www.twitch.tv/signup/")
            {
                this.user = this.RandomString(8);
                this.pass = this.RandomString(8);
                this.em = this.RandomString(5) + "@hotmail.com";
                this.setV(this.user, this.pass, this.em);
                this.getcbtn.Enabled = true;
                this.refcbtn.Enabled = true;
                return;
            }
            if ((sender as WebBrowser).DocumentText.Contains("Follow the latest Twitch news"))
            {
                string text = string.Concat(new string[]
				{
					this.user,
					":",
					this.pass,
					":",
					this.em
				});
                if (!this.acclb.Items.Contains(text))
                {
                    this.acclb.Items.Add(text);
                }
            }
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(this.acclb.SelectedItem.ToString());
            }
            catch
            {
            }
        }
        private void refcbtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.wb.Document.GetElementById("recaptcha_reload").InvokeMember("Click");
            this.getC();
        }
    }
}
