using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency1
{
    public partial class Info : Form
    {
        public Info(object data)
        {
            InitializeComponent();
            DisplayDetails(data);
        }

        private void DisplayDetails(object data)
        {
            if (data == null)
                return;
            Type type = data.GetType();
            PropertyInfo[] properties = type.GetProperties();

            int y = 10;
            foreach (PropertyInfo prop in properties)
            {
                Label label = new Label();
                label.Text = prop.Name + ":";
                label.Location = new Point(10, y);
                label.AutoSize = true;
                Controls.Add(label);

                Label valueLabel = new Label();
                valueLabel.Text = prop.GetValue(data)?.ToString();
                valueLabel.Location = new Point(100, y);
                valueLabel.AutoSize = true;
                Controls.Add(valueLabel);
                y += 20;
            }
        }
        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
