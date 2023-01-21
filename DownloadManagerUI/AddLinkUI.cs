using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace DownloadManagerUI
{
    public partial class AddLinkUI : Form
    {
        DownloadmanagerUI downloadManagerUI = null;
        public AddLinkUI(DownloadmanagerUI downloadManagerUI)
        {
            InitializeComponent();
            this.downloadManagerUI = downloadManagerUI;
        }

        public bool IsGoodStatus { get; set; }

        private void buttonCancelAddLink_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void buttonOKAddLink_Click(object sender, EventArgs e)
        {
            if (textBoxAddLink.Text != string.Empty)
            {
                //CheckLink(textBoxAddLink.Text);
                Task[] tasks = new Task[1] { Task.Run(() => CheckLink(textBoxAddLink.Text)) };
                await Task.WhenAll(tasks);
                //CheckLink(textBoxAddLink.Text);
                if (IsGoodStatus == true)
                {
                    if (!string.IsNullOrWhiteSpace(textBoxAddLink.Text))
                    {
                        downloadManagerUI.PassLink(textBoxAddLink.Text);
                        textBoxAddLink.Clear();
                    }
                }
                if (IsGoodStatus == false)
                {
                    textBoxAddLink.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("You can't input empty URL!\n" +
                    "Please enter valid URL",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckLink(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                IsGoodStatus = true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsGoodStatus = false;
            }
        }

        //RADI
        //private void CheckLink(string url)
        //{
        //    Thread thread = new Thread(() =>
        //    {
        //        try
        //        {
        //            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //            IsGoodStatus = true;
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show($"{e.Message}",
        //                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            IsGoodStatus = false;
        //        }
        //    });
        //    thread.Start();
        //    thread.Join();
        //}
    }
}

