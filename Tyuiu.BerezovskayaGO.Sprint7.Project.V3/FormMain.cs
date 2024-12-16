namespace Tyuiu.BerezovskayaGO.Sprint7.Project.V3
{
    public partial class FormMain_BGO : Form
    {
        public FormMain_BGO()
        {
            InitializeComponent();
        }

        private void buttonMain_BGO_Click(object sender, EventArgs e)
        {
            FormAbout_BGO formAbout_BGO = new FormAbout_BGO();
            formAbout_BGO.ShowDialog();
        }
    }
}
