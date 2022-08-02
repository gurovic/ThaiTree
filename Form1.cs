using System.Data;
using System.Data.SqlClient;

namespace ThaiTree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thaiCooDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(dataSet11.items);
            var data = this.itemsTableAdapter.GetData();
            treeView1.Nodes.Clear();
            foreach (var item in data)
            {
                Console.WriteLine(item["Id"] + "---" + item["parent"]);
                Console.WriteLine();
                if (item["Id"].ToString() == item["parent"].ToString())
                {
                    treeView1.Nodes.Add(item["Id"].ToString(), item["text"].ToString());
                    treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = item["order"].ToString();
                    Console.WriteLine(treeView1.Nodes[treeView1.Nodes.Count - 1].Tag + 
                        treeView1.Nodes[treeView1.Nodes.Count - 1].Name +
                        treeView1.Nodes[treeView1.Nodes.Count - 1].Text);
                }
                else
                {
                    treeView1.Nodes.Find(item["parent"].ToString(), true)[0].Nodes.Add(item["Id"].ToString(), item["text"].ToString());
                    treeView1.Nodes.Find(item["parent"].ToString(), true)[0].LastNode.Tag = item["order"].ToString();
                    Console.WriteLine(treeView1.Nodes.Find(item["parent"].ToString(), true)[0].LastNode.Tag +
                        treeView1.Nodes.Find(item["parent"].ToString(), true)[0].LastNode.Name +
                        treeView1.Nodes.Find(item["parent"].ToString(), true)[0].LastNode.Text);
                }
            }

        }
    }
}

