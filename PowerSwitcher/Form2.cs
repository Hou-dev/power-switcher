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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //declaring variables
 

        private void cmdPower_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/K powercfg -L");
        }

        private void enterStates_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("states.txt");
            File.WriteLine(balancedtxt.Text);
            File.WriteLine(hightxt.Text);
            File.WriteLine(powersavertxt.Text);
            File.WriteLine(amdbtxt.Text);
            File.WriteLine(amdhtxt.Text);
            File.Close();
        }

        private void powersavertxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void balancedtxt_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void hightxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void amdhtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void amdbtxt_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
