using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PowerSwitcher
{

    public partial class Form1 : Form
    {

        string f1balance;
        string f1powersaver;
        string f1high;
        string f1amdh;
        string f1amdb;

        public Form1()
        {

            InitializeComponent();
            StreamReader File = new StreamReader("states.txt");
            f1balance = File.ReadLine();
            f1high = File.ReadLine();
            f1powersaver = File.ReadLine();
            f1amdb = File.ReadLine();
            f1amdh = File.ReadLine();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clickSaver(object sender, EventArgs e)
        {
            
        }
      
        private void clickBal(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s 381b4222-f694-41f0-9685-ff5bb260df2e");
            System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s "+ f1balance);
        }

        private void clickHigh(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s " + f1high);
        }

        private void clickAMDB(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s " + f1amdb );
        }

        private void clickAMDH(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s " + f1amdh);
        }

        private void powerSaver_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C powercfg -s " + f1powersaver);
        }

        private void pwrConfig_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }
    }
    public class States
    {
        public string pwrS { get; set; }
        public string balC { get; set; }
        public string higH { get; set; }
        public string amdHP { get; set; }
        public string amdBP { get; set; }
    }
}
