using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentFormApp
{
	class Student // Corrected class name to follow C# naming conventions
	{
		public int cid { get; set; }
		public string stName { get; set; } // Corrected property name to follow C# naming conventions
		public string course { get; set; } // Corrected property name to follow C# naming conventions

		public void Reg(string name, string course)
		{
			// Connection string for the SQL Server
			SqlConnection con = new SqlConnection("Server=RDELROSARIO-22\\SQLEXPRESS02; Initial Catalog=kschool; Trusted_Connection=True;");

			// SQL query using parameters to prevent SQL injection
			string sql = "INSERT INTO students (stname, course) VALUES (@name, @course)";

			try
			{
				con.Open(); // Open the database connection

				// Creating the SQL command with the parameterized query
				SqlCommand cmd = new SqlCommand(sql, con);

				// Adding parameters to the command
				cmd.Parameters.AddWithValue("@name", name);
				cmd.Parameters.AddWithValue("@course", course);

				cmd.ExecuteNonQuery(); // Execute the command (insert data)
			}
			catch (SqlException ex)
			{
				// Handle SQL errors here
				Console.WriteLine("SQL Error: " + ex.Message);
			}
			finally
			{
				con.Close(); // Ensure the connection is closed
			}
		}

		// Corrected method return type and list declaration to use "Student" instead of "student"
		public List<Student> GetAllStudents()
		{
			List<Student> li = new List<Student>();
			SqlConnection con = new SqlConnection("Server=RDELROSARIO-22\\SQLEXPRESS02; Initial Catalog=kschool; Trusted_Connection=True;");

			string sql = "SELECT * FROM students";
			con.Open();

			SqlCommand cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				Student s = new Student();

				s.cid = (int)dr["id"];
				s.stName = dr["stname"].ToString();
				s.course = dr["course"].ToString();

				li.Add(s);
			}

			return li;
		}
	}
}