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
using System.Net.Http;

namespace DownloadManagerUI
{
    public partial class AddLinkUI : Form
    {
        DownloadmanagerUI downloadManagerUI = null;
        private readonly HttpClient _httpClient;
        public AddLinkUI(DownloadmanagerUI downloadManagerUI)
        {
            InitializeComponent();
            this.downloadManagerUI = downloadManagerUI;
            _httpClient = new HttpClient();
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

        private async Task CheckLink(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                    IsGoodStatus = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsGoodStatus = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid URL. Please enter a valid URL",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsGoodStatus = false;
            }
        }
    }
}

