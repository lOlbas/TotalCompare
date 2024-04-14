using TotalCompare.Data;

namespace TotalCompare.Views
{
    public partial class ProjectViewControl : UserControl
    {
        private List<string> _badPaths = new();

        public ProjectViewControl()
        {
            InitializeComponent();
        }

        public void OpenTCProject(TCProject project)
        {
            ValidateTCProject(project);
            LoadProjectView(project);
        }

        private void LoadProjectView(TCProject project)
        {
            projectTreeView.Nodes.Clear();
            _badPaths.Clear();

            foreach (var view in project.Views)
            {
                var newViewNode = new TreeNode(view.Name) { Tag = view };

                projectTreeView.Nodes.Add(newViewNode);
            }
        }

        private void ValidateTCProject(TCProject project)
        {
            ValidateSourcePaths(project.Sources);

            foreach (var view in project.Views)
            {
                ValidateSourcePaths(view, project.Sources);
            }
        }

        private void ValidateSourcePaths(TCSource source, TCSource? parent = null)
        {
            // var parentPath = parent.

            switch (source.ResolveType)
            {
                case TCResolveType.CommonBasePath:
                    {
                        if (source.CommonBasePath == null) { OnCorruptedProjectFile(); return; }
                        
                        if (!Directory.Exists(source.CommonBasePath))
                        {
                            _badPaths.Add(source.CommonBasePath);
                        }

                        if (source.Paths != null)
                        {
                            foreach (var path in source.Paths)
                            {
                                var fullPath = Path.Join(source.CommonBasePath, path);

                                if (!Directory.Exists(fullPath))
                                {
                                    _badPaths.Add(source.CommonBasePath);
                                }
                            }
                        }
                        break;
                    }
            }

            if (source.CommonBasePath != null)
            {
                
            }

            if (parent is null && source.PrimarySource != null)
            {
                // This should never happen for project source
            }

            if (parent != null && source.PrimarySource != null)
            {

            }
        }

        private void OnCorruptedProjectFile()
        {
            // TODO: implement
        }

        private void projectTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            projectTreeView.SelectedNode = projectTreeView.GetNodeAt(e.X, e.Y);
        }

        private void projectTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // OpenView(sender, e);
        }
    }
}
