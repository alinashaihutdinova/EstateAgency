using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency1
{
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            OpenMainForm(true); 
        }

        private void buttonLoadJson_Click(object sender, EventArgs e)
        {
            OpenMainForm(false); 
        }
        private void OpenMainForm(bool loadFromXml)
        {
            MainForm mainForm = new MainForm(loadFromXml); 
            mainForm.Show();
            this.Hide(); 
        }
    }
}
