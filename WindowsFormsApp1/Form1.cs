using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        StringBuilder stringBuilder = new StringBuilder();
        string openPath;
        public Form1()
        {
            InitializeComponent();
        }
        Form1 addMessage(string message)
        {
            stringBuilder.AppendLine(message);
            textBox1.Text = stringBuilder.ToString();
            return this;
        }
        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            addMessage($"Using file {openFileDialog.FileName}");
            openPath = openFileDialog.FileName;
        }
    }
}
