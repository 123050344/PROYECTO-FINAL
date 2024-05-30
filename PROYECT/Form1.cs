namespace PROYECT
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void AddToListView(string item)
        {
            lstnrecipes.Items.Add(new ListViewItem(item));
        }


        private void btncreate_Click(object sender, EventArgs e)
        {
            Form2 create = new Form2();
            create.Show();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            Form3 open = new Form3();
            open.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}