namespace FolderBrowser
{
    partial class FolderBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderBrowser));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.FileFolder = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.FileFolder;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(331, 337);
            this.treeView1.TabIndex = 0;
            // 
            // FileFolder
            // 
            this.FileFolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileFolder.ImageStream")));
            this.FileFolder.TransparentColor = System.Drawing.Color.Transparent;
            this.FileFolder.Images.SetKeyName(0, "ic_folder_black_48dp_2x.png");
            this.FileFolder.Images.SetKeyName(1, "ic_description_black_48dp_2x.png");
            // 
            // FolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "FolderBrowser";
            this.Size = new System.Drawing.Size(331, 337);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList FileFolder;
    }
}
