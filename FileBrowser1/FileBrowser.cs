using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FileBrowser
{
    public partial class FileBrowser: UserControl
    {
        
        public void ListDirectory(string path)
        {
            this.treeView1 = new TreeView();
            treeView1.Dock = DockStyle.Fill;
            Parallel.Invoke(()=> {
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

        private void FileBrowser_Load(object sender, System.EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

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
}

