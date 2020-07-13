using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            browser.Navigate(txtsearch.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String url = "http://www.google.com";
            browser.Navigate(url);
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtsearch.Text = browser.Document.Url.ToString();
            this.Text = browser.Document.Title;
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = browser.StatusText;
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch
            {

            }
        }
    }
}
