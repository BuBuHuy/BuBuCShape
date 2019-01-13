using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CshapeWinforBasic
{
    public partial class TreeViewDemo : Form
    {
        string path = @"D:\";
        public TreeViewDemo()
        {
            InitializeComponent();
            //LoadTreeView();
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                
                tw1.Nodes.Add(root);
                LoadExplorer(root);
            }
            
        }
        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            
            try { 
            var foderList = new DirectoryInfo(root.Text).GetDirectories();
            if(foderList.Count()==0)
            {
                return;
            }
            foreach (DirectoryInfo item in foderList)
            {
                if (Directory.Exists(item.FullName))
                {
                    TreeNode node = new TreeNode() { Text = item.FullName };
                    root.Nodes.Add(node);
                    LoadExplorer(node);
                }
            }
            }
            catch
            {
                return;
            }
        }
        void LoadTreeView()
        {
            TreeNode root1 = new TreeNode();
            root1.Text = "RootA1";
            root1.ImageIndex = 0;

            TreeNode node1 = new TreeNode() { Text ="Node A " };
            root1.Nodes.Add(node1);
            node1.ImageIndex = 1;

            TreeNode root2 = new TreeNode();
            root2.Text = "RootA2";
            root2.ImageIndex = 2;

            tw1.Nodes.Add(root1);
            tw1.Nodes.Add(root2);
        }
    }

}
