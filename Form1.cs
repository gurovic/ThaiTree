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

        static private double GetOrder(TreeNode node)
        {
            return (double.Parse(node.Tag.ToString()));
        }

        static private int GetId(TreeNode node)
        {
            //Console.WriteLine(node.Name);
            return int.Parse(node.Name);
        }


        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            itemsTableAdapter.Delete(GetId(treeView1.SelectedNode));
            treeView1.SelectedNode.Remove();
        }

        private void Add_node(TreeNode parent, string text, int index)
        {
            double order;
            if (index < 0)
            {
                order = 100;
            }
            else
            {
                if (index == 0)
                {
                    order = GetOrder(parent.FirstNode) / 2.0;
                }
                else
                {
                    if (index == parent.Nodes.Count)
                    {
                        order = GetOrder(parent.LastNode) + 100;
                    }
                    else
                    {


                        order = (GetOrder(parent.Nodes[index - 1]) + GetOrder(parent.Nodes[index])) / 2;
                    }
                }
            }
            int parentId = 0;

            if (text == "")
            {
                return;
            }

            if (parent != null)
            {
                parentId = GetId(parent);
            }
            TreeNode newNode = new(text);
            var id = itemsTableAdapter.InsertQuery(text, parentId, order);
            newNode.Tag = order.ToString();
            newNode.Name = id.ToString();
            if (index < 0)
            {
                parent.Nodes.Add(newNode);
            }
            else
            {
                parent.Nodes.Insert(index, newNode);
            }
            Console.WriteLine(newNode.Tag + " " + newNode.Text + " " + newNode.Name);
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                if (treeView1.SelectedNode != null)
                {
                    Add_node(treeView1.SelectedNode, AddBox.Text, -1);
                }
            }

        }

        private void AddBeforeButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null)
            {
                Add_node(treeView1.SelectedNode.Parent, AddBox.Text, treeView1.SelectedNode.Index);
            }
        }

        private void AddAfterButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null)
            {
                Add_node(treeView1.SelectedNode.Parent, AddBox.Text, treeView1.SelectedNode.Index + 1);
            }

        }

        private TreeNode SearchNode(string searchText, TreeNode startNode)
        {
            if (startNode != null && searchText != "")
            {
                if (startNode.Text.ToLower().Contains(searchText))
                {
                    return startNode;
                }

                foreach (TreeNode tn in startNode.Nodes)
                {
                    TreeNode found_node = SearchNode(searchText, tn);
                    if (found_node != null)
                    {
                        return found_node;
                    }
                }
            }
            return null;
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            TreeNode node = SearchNode(SearchBox.Text, treeView1.TopNode);
            if (node != null)
            {
                treeView1.SelectedNode = node;
                treeView1.Focus();

            }
        }

        private void TreeView1_Leave(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.BackColor = Color.LightBlue;
            }
        }

        private void TreeView1_Enter(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                treeView1.SelectedNode = treeView1.TopNode;
            }

            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.BackColor = Color.White;

            }
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
                    treeView1.Nodes.Add(item["Id"].ToString(), item["text"].ToString().Trim());
                    treeView1.Nodes[^1].Tag = item["order"].ToString();
                }
                else
                {
                    treeView1.Nodes.Find(item["parent"].ToString(), true)[0].Nodes.Add(item["Id"].ToString(), item["text"].ToString().Trim());
                    treeView1.Nodes.Find(item["parent"].ToString(), true)[0].LastNode.Tag = item["order"].ToString();
                }
            }

        }

        private void ItemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = AddBox.Text;
            itemsTableAdapter.UpdateQuery(AddBox.Text, GetId(treeView1.SelectedNode));
        }
    }
}

