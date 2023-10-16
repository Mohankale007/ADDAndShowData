namespace ADD_SHOW_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDDINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form=new Form2();
            form.ShowDialog();
        }
    }
}