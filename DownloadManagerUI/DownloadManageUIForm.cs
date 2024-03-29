﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace DownloadManagerUI
{

    public partial class DownloadmanagerUI : Form
    {
        public static string filePathDirectoryToWrite = @"C:\Users\machine\Downloads";
        public static List<string> filesToDownload = new List<string>();
        

        public void PassLink(string link)
        {   

            filesToDownload.Add(link);
            listBoxOfDownloadFiles.Items.Add(link);
        }

        public DownloadmanagerUI()
        {
            InitializeComponent();
            listBoxOfDownloadFiles.SelectionMode = SelectionMode.MultiExtended;
        }

        private void buttonSaveTo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    filePathDirectoryToWrite = folder.SelectedPath.ToString();
                } 
            }
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            Form formAddLink = new AddLinkUI(this);
            formAddLink.Show();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            if (filesToDownload.Count == 0 && listBoxOfDownloadFiles.Items.Count == 0)
            {
                MessageBox.Show("List is empty!\n" +
                   "Please enter URLs for download.",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            filesToDownload.Clear();
            listBoxOfDownloadFiles.Items.Clear();
        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {

            if (filesToDownload.Count == 0 && listBoxOfDownloadFiles.Items.Count == 0)
            {
                MessageBox.Show("List is empty, there is nothing to remove!\n" +
                   "Please enter URLs for download.",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listBoxOfDownloadFiles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item from list to remove link!\n",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            for (int i = 0; i < filesToDownload.Count; i++)
            {
                for (int j = 0; j < listBoxOfDownloadFiles.SelectedIndices.Count; j++)
                {
                    if (filesToDownload.IndexOf(filesToDownload[i]) == listBoxOfDownloadFiles.SelectedIndices[j])
                    {
                        filesToDownload.RemoveAt(i);
                        listBoxOfDownloadFiles.Items.RemoveAt(j);
                    }
                }
            }
        }

        //private void buttonRemoveLink_Click(object sender, EventArgs e)
        //{
        //    var selectedItems = listBoxOfDownloadFiles.SelectedItems;
        //    var linksToRemove = new List<string>();

        //    foreach (var item in selectedItems)
        //    {
        //        linksToRemove.Add(item.ToString());
        //    }

        //    filesToDownload.RemoveAll(x => linksToRemove.Contains(x));

        //    // Refresh the listbox
        //    listBoxOfDownloadFiles.DataSource = null;
        //    listBoxOfDownloadFiles.DataSource = filesToDownload;
        //}

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                await DownloadFileAsync();
                progressBar.Value = 100;
                labelStatusProgress.Text = "Download completed";
            }
            catch (Exception ex)
            {
                // code to handle any exceptions that may occur during the download process
                MessageBox.Show("An error occurred during the download process: " + ex.Message);
            }
        }

        //public async Task RunDownloadAsync()
        //{
        //    progressBar.Value = 0;
        //    progressBar.Maximum = 100;
        //    await Task.Run(() => DownloadFileAsync());
        //    labelStatusProgress.Text = "Files are downloaded!";

        //}
        //public async Task RunDownloadAsync()
        //{
        //    labelStatusProgress.Text = "Downloading is started...";
        //    await Task.Delay(1000);
        //    progressBar.Value = 0;
        //    progressBar.Maximum = 100;
        //    Thread thread = new Thread(async () =>
        //    {
        //        using (var webClient = new WebClient())
        //        {
        //            foreach (var link in filesToDownload)
        //            {
        //                string fileName = link.Split('/').Last();
        //                //Works only with AsyncDownload
        //                //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
        //                await Task.Run(() => webClient.DownloadFile(link, fileName));
        //                // Get the full path of the download and the destination folder.
        //                //string fromPath = Path.Combine(Application.StartupPath, fileName);
        //                //string toPath = Path.Combine(filePathDirectoryToWrite, fileName);
        //                //// Move the file.
        //                //File.Move(fromPath, toPath);
        //                await MoveFilesAsync(fileName);
        //            }
        //        }
        //    });
        //    thread.Start();
        //    progressBar.Value = 100;
        //    labelStatusProgress.Text = "Downloading is finished...";
        //}

        public void RunDownloadSync()
        {
            labelStatusProgress.Text = "Downloading is started...";
            Task.Delay(1000);
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            using (var webClient = new WebClient())
            {
                foreach (var link in filesToDownload)
                {
                    string fileName = link.Split('/').Last();
                    //Works only with AsyncDownload
                    //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
                    webClient.DownloadFile(link, fileName);
                    // Get the full path of the download and the destination folder.
                    string fromPath = Path.Combine(Application.StartupPath, fileName);
                    string toPath = Path.Combine(filePathDirectoryToWrite, fileName);
                    // Move the file.
                    File.Move(fromPath, toPath);
                }
            }
            progressBar.Value = 100;
            labelStatusProgress.Text = "Downloading is finished...";
        }

        public async Task DownloadFileAsync()
        {
            Task task = Task.Run(async () =>
            {
                using (var webClient = new WebClient())
                {
                    foreach (var link in filesToDownload)
                    {
                        string fileName = link.Split('/').Last();
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback4);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                        await Task.Run(() => webClient.DownloadFileTaskAsync(new Uri(link), fileName));
                        await MoveFilesAsync(fileName);
                    }
                    
                }
            });
            await task;
        }
        public void DownloadFileSync()
        {
            using (var webClient = new WebClient())
            {
                foreach (var link in filesToDownload)
                {
                    string fileName = link.Split('/').Last();
                    webClient.DownloadFile(link, fileName);
                    MoveFilesSync(fileName);
                }
            }
        }

        public async Task MoveFilesAsync(string fileName)
        {
            Task moveFilesTask = Task.Run(() => {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, fileName);
                string toPath = Path.Combine(filePathDirectoryToWrite, fileName);

                // Check if the file already exists in the destination folder.
                if (File.Exists(toPath))
                {
                    // Handle the file already exists case
                    Console.WriteLine("File already exists in the destination folder: " + toPath);
                    return;
                }
                // Move the file.
                File.Move(fromPath, toPath);
            });
            await moveFilesTask;
        }

            

        public void MoveFilesSync(string fileName)
        {
            // Get the full path of the download and the destination folder.
            string fromPath = Path.Combine(Application.StartupPath, fileName);
            string toPath = Path.Combine(filePathDirectoryToWrite, fileName);
            // Move the file.
            File.Move(fromPath, toPath);
        }

        private void DownloadProgressCallback4(object sender, DownloadProgressChangedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                labelStatusProgress.Text = "Downloaded " + e.BytesReceived/1000 + "kB of " + e.TotalBytesToReceive/1000 +"kB";
                progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                labelStatusProgress.Text = "File is downloaded!";
            });
        }
    }
}

