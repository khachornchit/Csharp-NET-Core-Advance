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

namespace WindowsFormsAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Task.Factory
            //    .StartNew(() => LongWait("John"))
            //    .ContinueWith(t => label1.Text = t.Result, TaskScheduler.FromCurrentSynchronizationContext());

            CallLongWait();
            label1.Text = "Waiting...";
        }

        private async void CallLongWait()
        {
            var result = await LongWaitAync("John");
            label1.Text = result;
        }

        private Task<string> LongWaitAync(string name )
        {
            return Task.Factory.StartNew(() => LongWait(name));
        }

        private string LongWait(string name)
        {
            Thread.Sleep(5000);
            return "Hello, " + name;
        }
    }
}
