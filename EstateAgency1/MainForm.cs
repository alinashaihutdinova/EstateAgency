using EstateAgency1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstateAgency1
{
    public partial class MainForm : Form
    {
        private Agency estateAgency;
        private bool loadFromXml;
        public MainForm(bool loadFromXml)
        {
            InitializeComponent();
            this.loadFromXml = loadFromXml;
        }
        private void PopulateTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Агентство: " + estateAgency.Name);
            treeView1.Nodes.Add(rootNode);
            TreeNode agentsNode = new TreeNode("Агенты");
            foreach (var agent in estateAgency.Agents)
            {
                TreeNode agentNode = new TreeNode($"{agent.FirstName} {agent.LastName}");
                agentNode.Tag = agent;
                agentsNode.Nodes.Add(agentNode);
            }
            rootNode.Nodes.Add(agentsNode);
            TreeNode estatesNode = new TreeNode("Объекты недвижимости");
            foreach (var estate in estateAgency.Estates)
            {
                TreeNode estateNode = new TreeNode($"Адрес: {estate.Address}");
                estateNode.Tag = estate;
                estatesNode.Nodes.Add(estateNode);
            }
            rootNode.Nodes.Add(estatesNode);
            treeView1.ExpandAll();
        }
        private void ShowDetails(object data)
        {
            dataGridView1.DataSource = null; 
            if (data is List<Agent> agentList) 
            {
                dataGridView1.DataSource = agentList; 
            }
            else if (data is List<Estate> estateList)
            {
                dataGridView1.DataSource = estateList;
            }
            else if (data is Agent agent)
            {
                List<Agent> agentList1 = new List<Agent> { agent };
                dataGridView1.DataSource = agentList1;
            }
            else if (data is Estate estate)
            {
                dataGridView1.DataSource = new List<Estate> { estate }; 
            }
        }
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Агенты")
            {
                ShowDetails(estateAgency.Agents); 
            }
            else if (e.Node.Text == "Объекты недвижимости") 
            {
                ShowDetails(estateAgency.Estates); 
            }
            else if (e.Node.Tag != null)
            {
                ShowDetails(e.Node.Tag);
            }
            else
            {
                dataGridView1.DataSource = null; 
            }
        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object selectedObject = dataGridView1.SelectedRows[0].DataBoundItem;
                if (selectedObject != null)
                {
                    Info detailsForm = new Info(selectedObject);
                    detailsForm.ShowDialog();
                }
            }
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            estateAgency = LoadData.LoadData_(loadFromXml);
            if (estateAgency != null)
            {
                PopulateTreeView();
            }
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
