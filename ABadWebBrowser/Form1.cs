﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABadWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoForward();
            } catch
            {

            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            try
            {

            } catch
            {
                webBrowser1.GoBack();
            }
        }
    }
}
