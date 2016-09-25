![alt tag](http://i.imgur.com/middQ05.png)


A file browser control for C#

#Appearance
![alt tag](http://i.imgur.com/VJJudhB.png)

#Usage
```csharp
  private void Form1_Load(object sender, EventArgs e)
  {
    folderBrowser2.ListDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
    folderBrowser2.treeView1.AfterSelect += (object sE, TreeViewEventArgs eA) => {
      if (((FolderFileNode)folderBrowser2.treeView1.SelectedNode).isFile)
      {
        MessageBox.Show(((FolderFileNode)folderBrowser2.treeView1.SelectedNode).Path);
      }
    };
  }
```
