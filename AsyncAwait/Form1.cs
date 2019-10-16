using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            CallUpdateMessage("John");
            labelStatus.Text = "Waiting...";
        }

        private async void CallUpdateMessage(string name)
        {
            var result = await UpdateMessageAsync(name);
            labelStatus.Text = result;
        }

        private Task<string> UpdateMessageAsync(string name)
        {
            return Task.Factory.StartNew(() => UpdateMessage(name));
        }

        private string UpdateMessage(string name)
        {
            Thread.Sleep(5000);
            return string.Format("Hello {0}, I'm here.", name);
        }

        private void buttonStatus1_Click(object sender, EventArgs e)
        {
            labelStatus1.Text = "Hello, I'm as status 1";
        }

        private void buttonStatus2_Click(object sender, EventArgs e)
        {
            labelStatus2.Text = "Hello, I'm as status 2";
        }
    }
}
