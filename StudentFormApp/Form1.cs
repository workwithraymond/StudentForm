namespace StudentFormApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Student ss = new Student();
			ss.Reg(txtname.Text, txtcourse.Text);
			MessageBox.Show("Record Added");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Student a = new Student();

			List<Student> cl = a.GetAllStudents();
			dataGridView1.DataSource = cl;
		}
	}
}
