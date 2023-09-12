using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
            
            reactor1Statelabel.BackColor = Color.Red;
            reactor2Statuslabel.BackColor = Color.Red;
            outputLabel.Text = "Reactors Melting Down";
            Refresh();
            Thread.Sleep(1000);
            reactor1Statelabel.BackColor = Color.White;
            reactor2Statuslabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1Statelabel.BackColor = Color.Red;
            reactor2Statuslabel.BackColor = Color.Red;
            outputLabel.Text = "Reactors Melting Down";
            Refresh();
            Thread.Sleep(1000);
            reactor1Statelabel.BackColor = Color.White;
            reactor2Statuslabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1Statelabel.BackColor = Color.Red;
            reactor2Statuslabel.BackColor = Color.Red;

        }
    }
}
