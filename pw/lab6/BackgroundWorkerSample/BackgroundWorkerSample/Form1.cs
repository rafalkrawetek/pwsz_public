﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace BackgroundWorkerSample
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The backgroundworker object on which the time consuming operation shall be executed
        /// </summary>
        BackgroundWorker m_oWorker;

        public Form1()
        {
            InitializeComponent();
            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
        }

        /// <summary>
        /// On completed do the appropriate task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                lblStatus.Text = "Task Completed...";
            }
            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;
        }

        /// <summary>
        /// Notification is performed here to the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Here you play with the main UI thread
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
        }

        /// <summary>
        /// Time consuming operations go here </br>
        /// i.e. Database operations,Reporting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            m_oWorker.ReportProgress(0);
            Random rnd = new Random();
            int found = 0;

            while (found<int.Parse(quantity.Text))
            {
                if (rnd.Next(int.Parse(min.Text), int.Parse(max.Text)+1) % int.Parse(div.Text) == 0)
                {
                    m_oWorker.ReportProgress((int)(++found / Convert.ToDouble(quantity.Text) * 100));
                }
                Thread.Sleep(100);
                if (m_oWorker.CancellationPending)
                {
                    e.Cancel = true;
                    m_oWorker.ReportProgress(0);
                    return;
                }
            }
        }

        private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            btnStartAsyncOperation.Enabled  = false;
            btnCancel.Enabled               = true;
            //Start the async operation here
            m_oWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_oWorker.IsBusy)
            {
                //Stop/Cancel the async operation here
                m_oWorker.CancelAsync();
            }
        }
    }
}
