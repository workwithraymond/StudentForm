using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentFormApp
{
	class student
	{
		public int Id { get; set; }
		public string stName { get; set; }
		public string course {  get; set; }

		public void reg(string name, string course)
		{
			SqlConnection con = new SqlConnection("server=.; int")
		}

	}
}
