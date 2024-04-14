namespace TotalCompare.Views
{
    partial class ProjectViewControl
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
            leftPanel = new Panel();
            projectGroupBox = new GroupBox();
            projectTreeView = new TreeView();
            splitter = new Splitter();
            leftPanel.SuspendLayout();
            projectGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(projectGroupBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 512);
            leftPanel.TabIndex = 0;
            // 
            // projectGroupBox
            // 
            projectGroupBox.Controls.Add(projectTreeView);
            projectGroupBox.Dock = DockStyle.Fill;
            projectGroupBox.Location = new Point(0, 0);
            projectGroupBox.Name = "projectGroupBox";
            projectGroupBox.Size = new Size(200, 512);
            projectGroupBox.TabIndex = 0;
            projectGroupBox.TabStop = false;
            projectGroupBox.Text = "Project";
            // 
            // projectTreeView
            // 
            projectTreeView.Dock = DockStyle.Fill;
            projectTreeView.Location = new Point(3, 19);
            projectTreeView.Name = "projectTreeView";
            projectTreeView.Size = new Size(194, 490);
            projectTreeView.TabIndex = 0;
            projectTreeView.NodeMouseClick += projectTreeView_NodeMouseClick;
            projectTreeView.NodeMouseDoubleClick += projectTreeView_NodeMouseDoubleClick;
            // 
            // splitter
            // 
            splitter.Location = new Point(200, 0);
            splitter.Name = "splitter";
            splitter.Size = new Size(3, 512);
            splitter.TabIndex = 1;
            splitter.TabStop = false;
            // 
            // ProjectViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitter);
            Controls.Add(leftPanel);
            Name = "ProjectViewControl";
            Size = new Size(768, 512);
            leftPanel.ResumeLayout(false);
            projectGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private GroupBox projectGroupBox;
        private TreeView projectTreeView;
        private Splitter splitter;
    }
}
