using TotalCompare.Data;
using TotalCompare.Views;

namespace TotalCompare.Forms
{
    public partial class TotalCompareForm : Form
    {
        public TotalCompareForm()
        {
            InitializeComponent();
        }

        private void TotalCompareForm_Load(object sender, EventArgs e)
        {
            CreateProjectView();
        }

        private void CreateProjectView()
        {
            Controls.Clear();

            var projectViewControl = new ProjectViewControl()
            {
                Dock = DockStyle.Fill
            };

            // projectViewControl.OpenTCProject(testProject);

            Controls.Add(projectViewControl);
            // Text = "TotalCompare - " + testProject.Name;
        }
    }
}
