﻿namespace ThaiTree
{
    partial class Form1
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.AddBeforeButton = new System.Windows.Forms.Button();
            this.AddAfterButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Dele = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1231, 31);
            this.SearchBox.TabIndex = 0;
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(12, 52);
            this.AddBox.Name = "AddBox";
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
            // 
            // AddBeforeButton
            // 
            this.AddBeforeButton.Location = new System.Drawing.Point(777, 49);
            this.AddBeforeButton.Name = "AddBeforeButton";
            this.AddBeforeButton.Size = new System.Drawing.Size(112, 34);
            this.AddBeforeButton.TabIndex = 3;
            this.AddBeforeButton.Text = "Add before";
            this.AddBeforeButton.UseVisualStyleBackColor = true;
            // 
            // AddAfterButton
            // 
            this.AddAfterButton.Location = new System.Drawing.Point(895, 49);
            this.AddAfterButton.Name = "AddAfterButton";
            this.AddAfterButton.Size = new System.Drawing.Size(112, 34);
            this.AddAfterButton.TabIndex = 4;
            this.AddAfterButton.Text = "Add after";
            this.AddAfterButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1013, 49);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 34);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // Dele
            // 
            this.Dele.Location = new System.Drawing.Point(1131, 49);
            this.Dele.Name = "Dele";
            this.Dele.Size = new System.Drawing.Size(112, 34);
            this.Dele.TabIndex = 6;
            this.Dele.Text = "Delete";
            this.Dele.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 89);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1231, 561);
            this.treeView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 662);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Dele);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddAfterButton);
            this.Controls.Add(this.AddBeforeButton);
            this.Controls.Add(this.AddChildButton);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.SearchBox);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private Button Dele;
        private TreeView treeView1;
    }
}