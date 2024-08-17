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
			student ss= new student();
			ss.reg(txtname.Text, txtcourse);
		}
	}
}
