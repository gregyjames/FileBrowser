using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderBrowser
{
    public partial class FolderBrowser: UserControl
    {
        public FolderBrowser()
        {
            InitializeComponent();
        }

        public void ListDirectory(string path)
        {
            Parallel.Invoke(() => {
                var rootDirectoryInfo = new DirectoryInfo(path);
                this.treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
            });
        }

        public static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            FolderFileNode directoryNode = new FolderFileNode(directoryInfo.Name, directoryInfo.FullName, false);
            foreach (var directory in directoryInfo.GetDirectories())
                try
                {
                    directoryNode.Nodes.Add(CreateDirectoryNode(directory));
                }
                catch { }
            foreach (var file in directoryInfo.GetFiles())
                try
                {
                    directoryNode.Nodes.Add(new FolderFileNode(file.Name, file.FullName, true));
                }
                catch { }
            return directoryNode;
        }
    }
}
public class FolderFileNode : TreeNode
{
    public string Path { get; set; }
    public FolderFileNode(string Text, string Path, bool isFile)
    {
        this.Text = Text;
        this.Path = Path;
        if (isFile)
        {
            this.ImageIndex = 1;
            this.SelectedImageIndex = 1;
        }
    }
}
