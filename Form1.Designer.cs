namespace ThaiTree
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.AddBeforeButton = new System.Windows.Forms.Button();
            this.AddAfterButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataSet11 = new ThaiTree.DataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new ThaiTree.DataSet1TableAdapters.itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search...";
            this.SearchBox.Size = new System.Drawing.Size(1231, 31);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUp);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(12, 52);
            this.AddBox.Name = "AddBox";
            this.AddBox.PlaceholderText = "Node text";
            this.AddBox.Size = new System.Drawing.Size(641, 31);
            this.AddBox.TabIndex = 1;
            // 
            // AddChildButton
            // 
            this.AddChildButton.Location = new System.Drawing.Point(659, 49);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(112, 34);
            this.AddChildButton.TabIndex = 2;
            this.AddChildButton.Text = "Add child";
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // AddBeforeButton
            // 
            this.AddBeforeButton.Location = new System.Drawing.Point(777, 49);
            this.AddBeforeButton.Name = "AddBeforeButton";
            this.AddBeforeButton.Size = new System.Drawing.Size(112, 34);
            this.AddBeforeButton.TabIndex = 3;
            this.AddBeforeButton.Text = "Add before";
            this.AddBeforeButton.UseVisualStyleBackColor = true;
            this.AddBeforeButton.Click += new System.EventHandler(this.AddBeforeButton_Click);
            // 
            // AddAfterButton
            // 
            this.AddAfterButton.Location = new System.Drawing.Point(895, 49);
            this.AddAfterButton.Name = "AddAfterButton";
            this.AddAfterButton.Size = new System.Drawing.Size(112, 34);
            this.AddAfterButton.TabIndex = 4;
            this.AddAfterButton.Text = "Add after";
            this.AddAfterButton.UseVisualStyleBackColor = true;
            this.AddAfterButton.Click += new System.EventHandler(this.AddAfterButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1013, 49);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 34);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1131, 49);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 34);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 89);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1231, 561);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.dataSet11;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 662);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddAfterButton);
            this.Controls.Add(this.AddBeforeButton);
            this.Controls.Add(this.AddChildButton);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.SearchBox);
            this.Name = "MainForm";
            this.Text = "Thai cooking tree info";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchBox;
        private TextBox AddBox;
        private Button AddChildButton;
        private Button AddBeforeButton;
        private Button AddAfterButton;
        private Button EditButton;
        private Button DeleteButton;
        private TreeView treeView1;
        private BindingSource bindingSource1;
        private DataSet1 dataSet11;
        private BindingSource itemsBindingSource;
        private DataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
    }
}