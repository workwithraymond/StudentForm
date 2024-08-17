namespace StudentFormApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtname = new TextBox();
			txtcourse = new TextBox();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// txtname
			// 
			txtname.Location = new Point(206, 67);
			txtname.Name = "txtname";
			txtname.Size = new Size(341, 31);
			txtname.TabIndex = 0;
			// 
			// txtcourse
			// 
			txtcourse.Location = new Point(206, 183);
			txtcourse.Name = "txtcourse";
			txtcourse.Size = new Size(341, 31);
			txtcourse.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(55, 67);
			label1.Name = "label1";
			label1.Size = new Size(125, 25);
			label1.TabIndex = 2;
			label1.Text = "Student Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(66, 189);
			label2.Name = "label2";
			label2.Size = new Size(67, 25);
			label2.TabIndex = 3;
			label2.Text = "Course";
			// 
			// button1
			// 
			button1.Location = new Point(212, 261);
			button1.Name = "button1";
			button1.Size = new Size(155, 42);
			button1.TabIndex = 4;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(631, 30);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(583, 313);
			dataGridView1.TabIndex = 5;
			// 
			// button2
			// 
			button2.Location = new Point(866, 384);
			button2.Name = "button2";
			button2.Size = new Size(143, 47);
			button2.TabIndex = 6;
			button2.Text = "View";
			button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1282, 653);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtcourse);
			Controls.Add(txtname);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Student Schedule";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtname;
		private TextBox txtcourse;
		private Label label1;
		private Label label2;
		private Button button1;
		private DataGridView dataGridView1;
		private Button button2;
	}
}
